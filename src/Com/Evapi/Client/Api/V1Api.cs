/**
 * Copyright 2014 ExaVault, Inc.
 *
 * File : V1Api.cs
 *
 * NOTE: This file was generated automatically. Do not modify by hand.
 */

using System;
using System.Collections.Generic;
using Com.Evapi.Client;
using Com.Evapi.Client.Model;
namespace Com.Evapi.Client.Api {
    public class V1Api {
		string basePath = "https://api.exavault.com";
		private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

		public ApiInvoker getInvoker() {
			return apiInvoker;
		}
      
		// Sets the endpoint base url for the services being accessed
		public void setBasePath(string basePath) {
			this.basePath = basePath;
		}
      
		// Gets the endpoint base url for the services being accessed
		public String getBasePath() {
			return basePath;
		}

		/// <summary>
		/// Authenticates a user into the API Returns access token in the Response object
		/// </summary>
		/// <param name="username">Name of of user to authenticate</param>
		/// <param name="password">User's password</param>
		/// <returns></returns>
		public AuthResponse authenticateUser (string username, string password) {
			// create path and map variables
			var operationPath = "/v1/authenticateUser".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (username == null || password == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (username != null){
				paramStr = (username != null && username is DateTime) ? ((DateTime)(object)username).ToString("u") : Convert.ToString(username);
				queryParams.Add("username", paramStr);
			}
			if (password != null){
				paramStr = (password != null && password is DateTime) ? ((DateTime)(object)password).ToString("u") : Convert.ToString(password);
				queryParams.Add("password", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (AuthResponse) ApiInvoker.deserialize(response, typeof(AuthResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Checks to see if each file or folder in the array exists Requires access token obtained via the authenticateUser operation
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="filePaths">Array containing paths of the files or folders to check</param>
		/// <returns></returns>
		public ExistingResourcesResponse checkFilesExist (string access_token, List<string> filePaths) {
			// create path and map variables
			var operationPath = "/v1/checkFilesExist".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || filePaths == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (filePaths != null){
				paramStr = (filePaths != null && filePaths is DateTime) ? ((DateTime)(object)filePaths).ToString("u") : Convert.ToString(filePaths);
				queryParams.Add("filePaths", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (ExistingResourcesResponse) ApiInvoker.deserialize(response, typeof(ExistingResourcesResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Copies files, folders to the destination path Requires access token obtained via the authenticateUser operation. Available to users with the 'upload' permission.
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="filePaths">Remote paths of the files or folders to copy</param>
		/// <param name="destinationPath">Remote destination path to copy files/folders to</param>
		/// <returns></returns>
		public ModifiedResourcesResponse copyResources (string access_token, List<string> filePaths, string destinationPath) {
			// create path and map variables
			var operationPath = "/v1/copyResources".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || filePaths == null || destinationPath == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (filePaths != null){
				paramStr = (filePaths != null && filePaths is DateTime) ? ((DateTime)(object)filePaths).ToString("u") : Convert.ToString(filePaths);
				queryParams.Add("filePaths", paramStr);
			}
			if (destinationPath != null){
				paramStr = (destinationPath != null && destinationPath is DateTime) ? ((DateTime)(object)destinationPath).ToString("u") : Convert.ToString(destinationPath);
				queryParams.Add("destinationPath", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (ModifiedResourcesResponse) ApiInvoker.deserialize(response, typeof(ModifiedResourcesResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Create a folder at a specified path Requires access token obtained via the authenticateUser operation. Available to users with the 'upload' permission.
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="folderName">Name of the folder to create</param>
		/// <param name="path">Where to create the folder</param>
		/// <returns></returns>
		public Response createFolder (string access_token, string folderName, string path) {
			// create path and map variables
			var operationPath = "/v1/createFolder".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || folderName == null || path == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (folderName != null){
				paramStr = (folderName != null && folderName is DateTime) ? ((DateTime)(object)folderName).ToString("u") : Convert.ToString(folderName);
				queryParams.Add("folderName", paramStr);
			}
			if (path != null){
				paramStr = (path != null && path is DateTime) ? ((DateTime)(object)path).ToString("u") : Convert.ToString(path);
				queryParams.Add("path", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (Response) ApiInvoker.deserialize(response, typeof(Response));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Adds a new subaccount user to the current account Requires access token obtained via the authenticateUser operation. Available to users with the 'manage users' permission
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="username">Name of the subaccount user to create</param>
		/// <param name="destinationFolder">The user's home folder</param>
		/// <param name="email">The user's email address</param>
		/// <param name="password">The user's password</param>
		/// <param name="role">The user's role, i.e: 'user' or 'admin'</param>
		/// <param name="permissions">An array of permissions for the user. The following values are supported: upload, download, delete, modify, list, changePassword, share, notification</param>
		/// <param name="nickname">The user's nickname</param>
		/// <param name="locked">If true, the user's account is locked by default</param>
		/// <param name="welcomeEmail">If true, send a user email upon creation</param>
		/// <param name="timeZone">The user's timezone, used for accurate time display within SWFT. See &lt;a href='https://php.net/manual/en/timezones.php' target='blank'&gt;this page&lt;/a&gt; for allowed values</param>
		/// <returns></returns>
		public Response createUser (string access_token, string username, string destinationFolder, string email, string password, string role, List<string> permissions, string nickname, bool locked, bool welcomeEmail, string timeZone) {
			// create path and map variables
			var operationPath = "/v1/createUser".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || username == null || destinationFolder == null || email == null || password == null || role == null || permissions == null || timeZone == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (username != null){
				paramStr = (username != null && username is DateTime) ? ((DateTime)(object)username).ToString("u") : Convert.ToString(username);
				queryParams.Add("username", paramStr);
			}
			if (destinationFolder != null){
				paramStr = (destinationFolder != null && destinationFolder is DateTime) ? ((DateTime)(object)destinationFolder).ToString("u") : Convert.ToString(destinationFolder);
				queryParams.Add("destinationFolder", paramStr);
			}
			if (email != null){
				paramStr = (email != null && email is DateTime) ? ((DateTime)(object)email).ToString("u") : Convert.ToString(email);
				queryParams.Add("email", paramStr);
			}
			if (password != null){
				paramStr = (password != null && password is DateTime) ? ((DateTime)(object)password).ToString("u") : Convert.ToString(password);
				queryParams.Add("password", paramStr);
			}
			if (role != null){
				paramStr = (role != null && role is DateTime) ? ((DateTime)(object)role).ToString("u") : Convert.ToString(role);
				queryParams.Add("role", paramStr);
			}
			if (permissions != null){
				paramStr = (permissions != null && permissions is DateTime) ? ((DateTime)(object)permissions).ToString("u") : Convert.ToString(permissions);
				queryParams.Add("permissions", paramStr);
			}
			if (timeZone != null){
				paramStr = (timeZone != null && timeZone is DateTime) ? ((DateTime)(object)timeZone).ToString("u") : Convert.ToString(timeZone);
				queryParams.Add("timeZone", paramStr);
			}
			if (nickname != null){
				paramStr = (nickname != null && nickname is DateTime) ? ((DateTime)(object)nickname).ToString("u") : Convert.ToString(nickname);
				queryParams.Add("nickname", paramStr);
			}
			if (locked != null){
				paramStr = (locked != null && locked is DateTime) ? ((DateTime)(object)locked).ToString("u") : Convert.ToString(locked);
				queryParams.Add("locked", paramStr);
			}
			if (welcomeEmail != null){
				paramStr = (welcomeEmail != null && welcomeEmail is DateTime) ? ((DateTime)(object)welcomeEmail).ToString("u") : Convert.ToString(welcomeEmail);
				queryParams.Add("welcomeEmail", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (Response) ApiInvoker.deserialize(response, typeof(Response));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Delete the specified files/folders Requires access token obtained via the authenticateUser operation. Available to users with the 'delete' permission
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="filePaths">Array containing paths of the files or folder to delete</param>
		/// <returns></returns>
		public FilesResponse deleteResources (string access_token, List<string> filePaths) {
			// create path and map variables
			var operationPath = "/v1/deleteResources".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || filePaths == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (filePaths != null){
				paramStr = (filePaths != null && filePaths is DateTime) ? ((DateTime)(object)filePaths).ToString("u") : Convert.ToString(filePaths);
				queryParams.Add("filePaths", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (FilesResponse) ApiInvoker.deserialize(response, typeof(FilesResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Deletes a subaccount user for the current account Requires access token obtained via the authenticateUser operation. Available to users with 'manage users' permission
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="username">Name of the subaccount user to delete</param>
		/// <returns></returns>
		public Response deleteUser (string access_token, string username) {
			// create path and map variables
			var operationPath = "/v1/deleteUser".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || username == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (username != null){
				paramStr = (username != null && username is DateTime) ? ((DateTime)(object)username).ToString("u") : Convert.ToString(username);
				queryParams.Add("username", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (Response) ApiInvoker.deserialize(response, typeof(Response));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Gets the account object for the currently logged in user Requires access token obtained via the authenticateUser operation
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <returns></returns>
		public AccountResponse getAccount (string access_token) {
			// create path and map variables
			var operationPath = "/v1/getAccount".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (AccountResponse) ApiInvoker.deserialize(response, typeof(AccountResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Gets the user object for the currently logged in user Requires access token obtained via the authenticateUser operation
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <returns></returns>
		public UserResponse getCurrentUser (string access_token) {
			// create path and map variables
			var operationPath = "/v1/getCurrentUser".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (UserResponse) ApiInvoker.deserialize(response, typeof(UserResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Returns a unique URL for handling file downloads Requires access token obtained via the authenticateUser operation. URL points at the appropriate storage server for file download.
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="filePaths">Path of file to be downloaded</param>
		/// <param name="downloadName">The name of the file to be downloaded</param>
		/// <returns></returns>
		public UrlResponse getDownloadFileUrl (string access_token, string filePaths, string downloadName) {
			// create path and map variables
			var operationPath = "/v1/getDownloadFileUrl".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || filePaths == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (filePaths != null){
				paramStr = (filePaths != null && filePaths is DateTime) ? ((DateTime)(object)filePaths).ToString("u") : Convert.ToString(filePaths);
				queryParams.Add("filePaths", paramStr);
			}
			if (downloadName != null){
				paramStr = (downloadName != null && downloadName is DateTime) ? ((DateTime)(object)downloadName).ToString("u") : Convert.ToString(downloadName);
				queryParams.Add("downloadName", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (UrlResponse) ApiInvoker.deserialize(response, typeof(UrlResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Returns a list of account activity. Allows for searching the activity log. 
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="filterBy">Field to search on ['filter_logs_date' or 'filter_logs_ip_address' or 'filter_logs_username' or 'filter_logs_operation' or 'filter_logs_file']</param>
		/// <param name="filter">Search criteria. For date ranges, use format 'start_date::end_date'</param>
		/// <param name="itemLimit">Number of logs to return. Can be used for pagination.</param>
		/// <param name="offset">Starting record in the result set. Can be used for pagination.</param>
		/// <param name="sortBy">Sort method ['sort_logs_date' or 'sort_logs_ip_address' or 'sort_logs_username' or 'sort_logs_file' or 'sort_logs_file_source' or 'sort_logs_operation', or 'sort_logs_duration', or 'sort_logs_size', or 'sort_logs_protocol']</param>
		/// <param name="sortOrder">Sort in either ascending or descending order: asc, desc</param>
		/// <returns></returns>
		public LogResponse getFileActivityLogs (string access_token, string filterBy, string filter, int itemLimit, int offset, string sortBy, string sortOrder) {
			// create path and map variables
			var operationPath = "/v1/getFileActivityLogs".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (offset != null){
				paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
				queryParams.Add("offset", paramStr);
			}
			if (sortBy != null){
				paramStr = (sortBy != null && sortBy is DateTime) ? ((DateTime)(object)sortBy).ToString("u") : Convert.ToString(sortBy);
				queryParams.Add("sortBy", paramStr);
			}
			if (sortOrder != null){
				paramStr = (sortOrder != null && sortOrder is DateTime) ? ((DateTime)(object)sortOrder).ToString("u") : Convert.ToString(sortOrder);
				queryParams.Add("sortOrder", paramStr);
			}
			if (filterBy != null){
				paramStr = (filterBy != null && filterBy is DateTime) ? ((DateTime)(object)filterBy).ToString("u") : Convert.ToString(filterBy);
				queryParams.Add("filterBy", paramStr);
			}
			if (filter != null){
				paramStr = (filter != null && filter is DateTime) ? ((DateTime)(object)filter).ToString("u") : Convert.ToString(filter);
				queryParams.Add("filter", paramStr);
			}
			if (itemLimit != null){
				paramStr = (itemLimit != null && itemLimit is DateTime) ? ((DateTime)(object)itemLimit).ToString("u") : Convert.ToString(itemLimit);
				queryParams.Add("itemLimit", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (LogResponse) ApiInvoker.deserialize(response, typeof(LogResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Get folders for a specified path Requires access token obtained via the authenticateUser operation
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="path">The remote file path</param>
		/// <returns></returns>
		public ResourcePropertiesResponse getFolders (string access_token, string path) {
			// create path and map variables
			var operationPath = "/v1/getFolders".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || path == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (path != null){
				paramStr = (path != null && path is DateTime) ? ((DateTime)(object)path).ToString("u") : Convert.ToString(path);
				queryParams.Add("path", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (ResourcePropertiesResponse) ApiInvoker.deserialize(response, typeof(ResourcePropertiesResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Get a listing of files/folders for the specified path Requires access token obtained via the authenticateUser operation. Available to users with 'list files' permission.
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="path">The remote file path</param>
		/// <param name="sortBy">Sort according to attribute: sort_files_name, sort_files_size, sort_files_date, sort_files_type, sort_files_timeline</param>
		/// <param name="sortOrder">Sort in either ascending or descending order: asc, desc</param>
		/// <param name="offset">Determines which item to start on for pagination</param>
		/// <param name="limit">The number of files to limit the result</param>
		/// <param name="detailed">If true, returns sharedFolder, notifications or other objects associated with specified path</param>
		/// <param name="pattern">Regex string. If not null, perform a search with specified pattern</param>
		/// <returns></returns>
		public ResourceResponse getResourceList (string access_token, string path, string sortBy, string sortOrder, int offset, int limit, bool detailed, string pattern) {
			// create path and map variables
			var operationPath = "/v1/getResourceList".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || path == null || sortBy == null || sortOrder == null || offset == null || limit == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (path != null){
				paramStr = (path != null && path is DateTime) ? ((DateTime)(object)path).ToString("u") : Convert.ToString(path);
				queryParams.Add("path", paramStr);
			}
			if (sortBy != null){
				paramStr = (sortBy != null && sortBy is DateTime) ? ((DateTime)(object)sortBy).ToString("u") : Convert.ToString(sortBy);
				queryParams.Add("sortBy", paramStr);
			}
			if (sortOrder != null){
				paramStr = (sortOrder != null && sortOrder is DateTime) ? ((DateTime)(object)sortOrder).ToString("u") : Convert.ToString(sortOrder);
				queryParams.Add("sortOrder", paramStr);
			}
			if (offset != null){
				paramStr = (offset != null && offset is DateTime) ? ((DateTime)(object)offset).ToString("u") : Convert.ToString(offset);
				queryParams.Add("offset", paramStr);
			}
			if (limit != null){
				paramStr = (limit != null && limit is DateTime) ? ((DateTime)(object)limit).ToString("u") : Convert.ToString(limit);
				queryParams.Add("limit", paramStr);
			}
			if (detailed != null){
				paramStr = (detailed != null && detailed is DateTime) ? ((DateTime)(object)detailed).ToString("u") : Convert.ToString(detailed);
				queryParams.Add("detailed", paramStr);
			}
			if (pattern != null){
				paramStr = (pattern != null && pattern is DateTime) ? ((DateTime)(object)pattern).ToString("u") : Convert.ToString(pattern);
				queryParams.Add("pattern", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (ResourceResponse) ApiInvoker.deserialize(response, typeof(ResourceResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Get the properties for each of the specified files/folders. Requires access token obtained via the authenticateUser operation
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="filePaths">Array containing paths of the files or folder to get</param>
		/// <returns></returns>
		public ResourcePropertiesResponse getResourceProperties (string access_token, List<string> filePaths) {
			// create path and map variables
			var operationPath = "/v1/getResourceProperties".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || filePaths == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (filePaths != null){
				paramStr = (filePaths != null && filePaths is DateTime) ? ((DateTime)(object)filePaths).ToString("u") : Convert.ToString(filePaths);
				queryParams.Add("filePaths", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (ResourcePropertiesResponse) ApiInvoker.deserialize(response, typeof(ResourcePropertiesResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Returns a unique URL for handling file uploads Requires access token obtained via the authenticateUser operation. Called before an upload is started to get URL to appropriate storage server. Available to users with the 'write' permission.
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="fileSize">Size of the file to upload, in bytes</param>
		/// <param name="destinationPath">Path relative to account's home directory, including file name</param>
		/// <param name="allowOverwrite">True if the file should be overwritten, false if different file names should be generated</param>
		/// <param name="resume">True if upload resume is supported, false if it isn't</param>
		/// <returns></returns>
		public UrlResponse getUploadFileUrl (string access_token, int fileSize, string destinationPath, bool allowOverwrite, bool resume) {
			// create path and map variables
			var operationPath = "/v1/getUploadFileUrl".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || fileSize == null || destinationPath == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (fileSize != null){
				paramStr = (fileSize != null && fileSize is DateTime) ? ((DateTime)(object)fileSize).ToString("u") : Convert.ToString(fileSize);
				queryParams.Add("fileSize", paramStr);
			}
			if (destinationPath != null){
				paramStr = (destinationPath != null && destinationPath is DateTime) ? ((DateTime)(object)destinationPath).ToString("u") : Convert.ToString(destinationPath);
				queryParams.Add("destinationPath", paramStr);
			}
			if (allowOverwrite != null){
				paramStr = (allowOverwrite != null && allowOverwrite is DateTime) ? ((DateTime)(object)allowOverwrite).ToString("u") : Convert.ToString(allowOverwrite);
				queryParams.Add("allowOverwrite", paramStr);
			}
			if (resume != null){
				paramStr = (resume != null && resume is DateTime) ? ((DateTime)(object)resume).ToString("u") : Convert.ToString(resume);
				queryParams.Add("resume", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (UrlResponse) ApiInvoker.deserialize(response, typeof(UrlResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Get the specified subaccount user for the current account Requires access token obtained via the authenticateUser operation
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="username">Name of the subaccount user to get</param>
		/// <returns></returns>
		public UserResponse getUser (string access_token, string username) {
			// create path and map variables
			var operationPath = "/v1/getUser".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || username == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (username != null){
				paramStr = (username != null && username is DateTime) ? ((DateTime)(object)username).ToString("u") : Convert.ToString(username);
				queryParams.Add("username", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (UserResponse) ApiInvoker.deserialize(response, typeof(UserResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Gets the user object for the currently logged in user Requires access token obtained via the authenticateUser operation. Available to users with the 'manage users' permission set
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="sortBy">sort method ['sort_users_username' or 'sort_users_nickname' or 'sort_users_email' or 'sort_users_home_folder' or 'sort_users_permissions']</param>
		/// <param name="sortOrder">sort order, i.e. 'asc' or 'desc'</param>
		/// <returns></returns>
		public UsersResponse getUsers (string access_token, string sortBy, string sortOrder) {
			// create path and map variables
			var operationPath = "/v1/getUsers".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || sortBy == null || sortOrder == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (sortBy != null){
				paramStr = (sortBy != null && sortBy is DateTime) ? ((DateTime)(object)sortBy).ToString("u") : Convert.ToString(sortBy);
				queryParams.Add("sortBy", paramStr);
			}
			if (sortOrder != null){
				paramStr = (sortOrder != null && sortOrder is DateTime) ? ((DateTime)(object)sortOrder).ToString("u") : Convert.ToString(sortOrder);
				queryParams.Add("sortOrder", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (UsersResponse) ApiInvoker.deserialize(response, typeof(UsersResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Removes user's access token from database, logging them out of API Requires access token obtained via the authenticateUser operation
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <returns></returns>
		public Response logoutUser (string access_token) {
			// create path and map variables
			var operationPath = "/v1/logoutUser".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (Response) ApiInvoker.deserialize(response, typeof(Response));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Moves files, folders to the destination path Requires access token obtained via the authenticateUser operation. Available to users with the 'upload' permission
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="filePaths">Remote paths of the files or folders to move</param>
		/// <param name="destinationPath">Remote destination path to move files/folders to</param>
		/// <returns></returns>
		public ModifiedResourcesResponse moveResources (string access_token, List<string> filePaths, string destinationPath) {
			// create path and map variables
			var operationPath = "/v1/moveResources".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || filePaths == null || destinationPath == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (filePaths != null){
				paramStr = (filePaths != null && filePaths is DateTime) ? ((DateTime)(object)filePaths).ToString("u") : Convert.ToString(filePaths);
				queryParams.Add("filePaths", paramStr);
			}
			if (destinationPath != null){
				paramStr = (destinationPath != null && destinationPath is DateTime) ? ((DateTime)(object)destinationPath).ToString("u") : Convert.ToString(destinationPath);
				queryParams.Add("destinationPath", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (ModifiedResourcesResponse) ApiInvoker.deserialize(response, typeof(ModifiedResourcesResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Returns a resized image of the specified document for support file types Requires access token obtained via authenticateUser operation
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="path">Path of the image relative to the user's home directory</param>
		/// <param name="size">The size of the image: small, medium, large</param>
		/// <param name="width">Overrides sizes. Sets to a specific width</param>
		/// <param name="height">Overrides sizes. Sets to a specific height</param>
		/// <param name="page">Page number for the document</param>
		/// <returns></returns>
		public PreviewFileResponse previewFile (string access_token, string path, string size, int width, int height, int page) {
			// create path and map variables
			var operationPath = "/v1/previewFile".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || path == null || size == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (path != null){
				paramStr = (path != null && path is DateTime) ? ((DateTime)(object)path).ToString("u") : Convert.ToString(path);
				queryParams.Add("path", paramStr);
			}
			if (size != null){
				paramStr = (size != null && size is DateTime) ? ((DateTime)(object)size).ToString("u") : Convert.ToString(size);
				queryParams.Add("size", paramStr);
			}
			if (width != null){
				paramStr = (width != null && width is DateTime) ? ((DateTime)(object)width).ToString("u") : Convert.ToString(width);
				queryParams.Add("width", paramStr);
			}
			if (height != null){
				paramStr = (height != null && height is DateTime) ? ((DateTime)(object)height).ToString("u") : Convert.ToString(height);
				queryParams.Add("height", paramStr);
			}
			if (page != null){
				paramStr = (page != null && page is DateTime) ? ((DateTime)(object)page).ToString("u") : Convert.ToString(page);
				queryParams.Add("page", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (PreviewFileResponse) ApiInvoker.deserialize(response, typeof(PreviewFileResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Rename a file or folder at the specified path Requires access token obtained via the authenticateUser operation. Available to users with the 'modify' permission
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="filePath">Remote path of the files or folder to rename</param>
		/// <param name="newName">The new name of the file or folder</param>
		/// <returns></returns>
		public Response renameResource (string access_token, string filePath, string newName) {
			// create path and map variables
			var operationPath = "/v1/renameResource".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || filePath == null || newName == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (filePath != null){
				paramStr = (filePath != null && filePath is DateTime) ? ((DateTime)(object)filePath).ToString("u") : Convert.ToString(filePath);
				queryParams.Add("filePath", paramStr);
			}
			if (newName != null){
				paramStr = (newName != null && newName is DateTime) ? ((DateTime)(object)newName).ToString("u") : Convert.ToString(newName);
				queryParams.Add("newName", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (Response) ApiInvoker.deserialize(response, typeof(Response));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Updates a subaccount user for the current account Requires access token obtained via the authenticateUser operation. Available to users with 'manage users' permission
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="userId">The user ID, must be obtained from getUser method first</param>
		/// <param name="username">Name of the subaccount user to modify</param>
		/// <param name="nickname">The user's nickname</param>
		/// <param name="email">The user's email</param>
		/// <param name="destinationFolder">The user's home folder</param>
		/// <param name="password">The user's password</param>
		/// <param name="locked">If true, the user's account is locked by default</param>
		/// <param name="role">The user's role, i.e: 'user', 'admin', 'master'</param>
		/// <param name="permissions">An array of permissions for the user</param>
		/// <returns></returns>
		public Response updateUser (string access_token, int userId, string username, string nickname, string email, string destinationFolder, string password, bool locked, string role, List<string> permissions) {
			// create path and map variables
			var operationPath = "/v1/updateUser".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || userId == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (userId != null){
				paramStr = (userId != null && userId is DateTime) ? ((DateTime)(object)userId).ToString("u") : Convert.ToString(userId);
				queryParams.Add("userId", paramStr);
			}
			if (username != null){
				paramStr = (username != null && username is DateTime) ? ((DateTime)(object)username).ToString("u") : Convert.ToString(username);
				queryParams.Add("username", paramStr);
			}
			if (nickname != null){
				paramStr = (nickname != null && nickname is DateTime) ? ((DateTime)(object)nickname).ToString("u") : Convert.ToString(nickname);
				queryParams.Add("nickname", paramStr);
			}
			if (email != null){
				paramStr = (email != null && email is DateTime) ? ((DateTime)(object)email).ToString("u") : Convert.ToString(email);
				queryParams.Add("email", paramStr);
			}
			if (destinationFolder != null){
				paramStr = (destinationFolder != null && destinationFolder is DateTime) ? ((DateTime)(object)destinationFolder).ToString("u") : Convert.ToString(destinationFolder);
				queryParams.Add("destinationFolder", paramStr);
			}
			if (password != null){
				paramStr = (password != null && password is DateTime) ? ((DateTime)(object)password).ToString("u") : Convert.ToString(password);
				queryParams.Add("password", paramStr);
			}
			if (locked != null){
				paramStr = (locked != null && locked is DateTime) ? ((DateTime)(object)locked).ToString("u") : Convert.ToString(locked);
				queryParams.Add("locked", paramStr);
			}
			if (role != null){
				paramStr = (role != null && role is DateTime) ? ((DateTime)(object)role).ToString("u") : Convert.ToString(role);
				queryParams.Add("role", paramStr);
			}
			if (permissions != null){
				paramStr = (permissions != null && permissions is DateTime) ? ((DateTime)(object)permissions).ToString("u") : Convert.ToString(permissions);
				queryParams.Add("permissions", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (Response) ApiInvoker.deserialize(response, typeof(Response));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		/// <summary>
		/// Returns true if requested username has not already been taken in the system 
		/// </summary>
		/// <param name="access_token">Access token required to make the API call</param>
		/// <param name="username">Username to check</param>
		/// <returns></returns>
		public AvailableUserResponse userAvailable (string access_token, string username) {
			// create path and map variables
			var operationPath = "/v1/userAvailable".Replace("{format}","json");

			// query params
			var queryParams = new Dictionary<String, String>();
			var headerParams = new Dictionary<String, String>();

			// verify required params are set
			if (access_token == null || username == null ) {
				throw new ApiException(400, "missing required params");
			}
			string paramStr = null;
			if (access_token != null){
				paramStr = (access_token != null && access_token is DateTime) ? ((DateTime)(object)access_token).ToString("u") : Convert.ToString(access_token);
				queryParams.Add("access_token", paramStr);
			}
			if (username != null){
				paramStr = (username != null && username is DateTime) ? ((DateTime)(object)username).ToString("u") : Convert.ToString(username);
				queryParams.Add("username", paramStr);
			}
			try {
				var response = apiInvoker.invokeAPI(basePath, operationPath, "GET", queryParams, null, headerParams);
				if(response != null){
					return (AvailableUserResponse) ApiInvoker.deserialize(response, typeof(AvailableUserResponse));
				}
				else {
					return null;
				}
			} catch (ApiException ex) {
				if(ex.ErrorCode == 404) {
					return null;
				}
				else {
					throw ex;
				}
			}
		}
		}
    }

