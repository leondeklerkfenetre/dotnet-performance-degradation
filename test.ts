process.env["NODE_TLS_REJECT_UNAUTHORIZED"] = 0;

const baseUrl = "https://localhost:7241/api";
import https from "node:https";

const insecureAgent = new https.Agent({ rejectUnauthorized: false });

const fetchGet = async (url: string, ...options: { name: string; value: string }[]) => {
	const response = await fetch(baseUrl + url, {
		method: "GET",
		headers: {
			"Content-Type": "application/json",
			...options.reduce(
				(acc, curr) => {
					acc[curr.name] = curr.value;
					return acc;
				},
				{} as Record<string, string>,
			),
		},
	});
	return response.text();
};

const fetchPost = async (url: string, body: any) => {
	const response = await fetch(baseUrl + url, {
		method: "POST",
		headers: {
			"Content-Type": "application/json",
		},
		body: JSON.stringify(body),
	});
	return response.text();
};

const login = async () => {
	return fetchPost("/Authentication/SignInWithEmailPassword", { emailAddress: "testuser", password: "P@ssw0rd!", authenticationMethod: "string" });
};

const checkBrowser = async () => {
	return fetchGet("//CheckBrowser");
};

const isAuthenticated = async () => {
	return fetchGet("/Authentication/IsAuthenticated");
};

const getGenericFrontEndSettings = async () => {
	return fetchGet("/Setting/GetGenericFrontEndSettings");
};

const getGlobalTabsSettings = async () => {
	return fetchGet("/Setting/GetGlobalTabsSettings");
};

const getCanLinkUsersFromOtherOrganizations = async () => {
	return fetchGet("/Security/CanLinkUsersFromOtherOrganizations");
};

const getGeneralApplicationData = async () => {
	return fetchGet("/General/GetGeneralApplicationData");
};

const getGUISettings = async () => {
	return fetchGet("/Account/GetGUISettings");
};

const getCanViewAllOrganizations = async () => {
	return fetchGet("/Security/CanViewAllOrganizations");
};

const isCIDRValid = async () => {
	return fetchGet("/Account/IsCIDRValid");
};

const getLocalizedResourcesGeneric = async () => {
	return fetchGet("/GetGenericControls/GetLocalizedResources");
};

const getGlobalResources = async () => {
	return fetchGet("/Resource/GetGlobalResources");
};

const getLocalizedResourcesResource = async () => {
	return fetchGet("/Resource/GetLocalizedResources");
};

const getIsAdministrator = async () => {
	return fetchGet("/Security/GetIsAdministrator");
};

const topBarData = async () => {
	return fetchGet("/Entity/GetTopBarData");
};

const getOrganizationGUISettings = async () => {
	return fetchGet("/Account/GetOrganizationGUISettings");
};

const allTimings = [];

const makeTimedRequest = async (request: () => Promise<any>, name: string) => {
	const start = performance.now();
	await request();
	const end = performance.now();
	allTimings.push(end - start);
	console.log(`Request ${name} took ${end - start} milliseconds`);
};

await makeTimedRequest(login, "Login");
await Promise.all([makeTimedRequest(checkBrowser, "CheckBrowser"), makeTimedRequest(isAuthenticated, "IsAuthenticated")]);

await makeTimedRequest(getGenericFrontEndSettings, "getGenericFrontEndSettings");
await makeTimedRequest(getGlobalTabsSettings, "GetGlobalTabsSettings");

// Remaining request in batch
await Promise.all([
	makeTimedRequest(getGeneralApplicationData, "getGeneralApplicationData"),
	makeTimedRequest(getLocalizedResourcesGeneric, "getLocalizedResourcesGeneric"),
	makeTimedRequest(getLocalizedResourcesResource, "getLocalizedResourcesResource"),
	makeTimedRequest(getGlobalResources, "getGlobalResources"),
	makeTimedRequest(isCIDRValid, "isCIDRValid"),
	makeTimedRequest(getIsAdministrator, "getIsAdministrator"),
	makeTimedRequest(getCanViewAllOrganizations, "getCanViewAllOrganizations"),
	makeTimedRequest(getCanLinkUsersFromOtherOrganizations, "getCanLinkUsersFromOtherOrganizations"),
	makeTimedRequest(topBarData, "topBarData"),
	makeTimedRequest(getGUISettings, "getGUISettings"),
	makeTimedRequest(getOrganizationGUISettings, "getOrganizationGUISettings"),
]);

const average = allTimings.reduce((a, b) => a + b, 0) / allTimings.length;
console.log(`Average request time: ${average} milliseconds`);
