/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations;
using Amazon.CognitoIdentityProvider.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentityProvider
{
    /// <summary>
    /// Implementation for accessing CognitoIdentityProvider
    ///
    /// Using the Amazon Cognito User Pools API, you can create a user pool to manage directories
    /// and users. You can authenticate a user to obtain tokens related to user identity and
    /// access policies.
    /// 
    ///  
    /// <para>
    /// This API reference provides information about user pools in Amazon Cognito User Pools.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the Amazon Cognito Documentation.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoIdentityProviderClient : AmazonServiceClient, IAmazonCognitoIdentityProvider
    {
        private static IServiceMetadata serviceMetadata = new AmazonCognitoIdentityProviderMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials)
            : this(credentials, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCognitoIdentityProviderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Credentials and an
        /// AmazonCognitoIdentityProviderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(AWSCredentials credentials, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityProviderConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityProviderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityProviderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityProviderConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityProviderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityProviderClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityProviderClient Configuration Object</param>
        public AmazonCognitoIdentityProviderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityProviderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddCustomAttributes
        internal virtual AddCustomAttributesResponse AddCustomAttributes(AddCustomAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddCustomAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;

            return Invoke<AddCustomAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddCustomAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddCustomAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AddCustomAttributes">REST API Reference for AddCustomAttributes Operation</seealso>
        public virtual void AddCustomAttributesAsync(AddCustomAttributesRequest request, AmazonServiceCallback<AddCustomAttributesRequest, AddCustomAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AddCustomAttributesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AddCustomAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AddCustomAttributesRequest,AddCustomAttributesResponse> responseObject 
                            = new AmazonServiceResult<AddCustomAttributesRequest,AddCustomAttributesResponse>((AddCustomAttributesRequest)req, (AddCustomAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminAddUserToGroup
        internal virtual AdminAddUserToGroupResponse AdminAddUserToGroup(AdminAddUserToGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminAddUserToGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminAddUserToGroupResponseUnmarshaller.Instance;

            return Invoke<AdminAddUserToGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminAddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminAddUserToGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminAddUserToGroup">REST API Reference for AdminAddUserToGroup Operation</seealso>
        public virtual void AdminAddUserToGroupAsync(AdminAddUserToGroupRequest request, AmazonServiceCallback<AdminAddUserToGroupRequest, AdminAddUserToGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminAddUserToGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminAddUserToGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminAddUserToGroupRequest,AdminAddUserToGroupResponse> responseObject 
                            = new AmazonServiceResult<AdminAddUserToGroupRequest,AdminAddUserToGroupResponse>((AdminAddUserToGroupRequest)req, (AdminAddUserToGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminConfirmSignUp
        internal virtual AdminConfirmSignUpResponse AdminConfirmSignUp(AdminConfirmSignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<AdminConfirmSignUpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminConfirmSignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminConfirmSignUp">REST API Reference for AdminConfirmSignUp Operation</seealso>
        public virtual void AdminConfirmSignUpAsync(AdminConfirmSignUpRequest request, AmazonServiceCallback<AdminConfirmSignUpRequest, AdminConfirmSignUpResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminConfirmSignUpRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminConfirmSignUpResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminConfirmSignUpRequest,AdminConfirmSignUpResponse> responseObject 
                            = new AmazonServiceResult<AdminConfirmSignUpRequest,AdminConfirmSignUpResponse>((AdminConfirmSignUpRequest)req, (AdminConfirmSignUpResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminCreateUser
        internal virtual AdminCreateUserResponse AdminCreateUser(AdminCreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminCreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminCreateUserResponseUnmarshaller.Instance;

            return Invoke<AdminCreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminCreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminCreateUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminCreateUser">REST API Reference for AdminCreateUser Operation</seealso>
        public virtual void AdminCreateUserAsync(AdminCreateUserRequest request, AmazonServiceCallback<AdminCreateUserRequest, AdminCreateUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminCreateUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminCreateUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminCreateUserRequest,AdminCreateUserResponse> responseObject 
                            = new AmazonServiceResult<AdminCreateUserRequest,AdminCreateUserResponse>((AdminCreateUserRequest)req, (AdminCreateUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminDeleteUser
        internal virtual AdminDeleteUserResponse AdminDeleteUser(AdminDeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUser">REST API Reference for AdminDeleteUser Operation</seealso>
        public virtual void AdminDeleteUserAsync(AdminDeleteUserRequest request, AmazonServiceCallback<AdminDeleteUserRequest, AdminDeleteUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminDeleteUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminDeleteUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminDeleteUserRequest,AdminDeleteUserResponse> responseObject 
                            = new AmazonServiceResult<AdminDeleteUserRequest,AdminDeleteUserResponse>((AdminDeleteUserRequest)req, (AdminDeleteUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminDeleteUserAttributes
        internal virtual AdminDeleteUserAttributesResponse AdminDeleteUserAttributes(AdminDeleteUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminDeleteUserAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDeleteUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDeleteUserAttributes">REST API Reference for AdminDeleteUserAttributes Operation</seealso>
        public virtual void AdminDeleteUserAttributesAsync(AdminDeleteUserAttributesRequest request, AmazonServiceCallback<AdminDeleteUserAttributesRequest, AdminDeleteUserAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminDeleteUserAttributesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminDeleteUserAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminDeleteUserAttributesRequest,AdminDeleteUserAttributesResponse> responseObject 
                            = new AmazonServiceResult<AdminDeleteUserAttributesRequest,AdminDeleteUserAttributesResponse>((AdminDeleteUserAttributesRequest)req, (AdminDeleteUserAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminDisableProviderForUser
        internal virtual AdminDisableProviderForUserResponse AdminDisableProviderForUser(AdminDisableProviderForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableProviderForUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableProviderForUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableProviderForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableProviderForUser">REST API Reference for AdminDisableProviderForUser Operation</seealso>
        public virtual void AdminDisableProviderForUserAsync(AdminDisableProviderForUserRequest request, AmazonServiceCallback<AdminDisableProviderForUserRequest, AdminDisableProviderForUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminDisableProviderForUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminDisableProviderForUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminDisableProviderForUserRequest,AdminDisableProviderForUserResponse> responseObject 
                            = new AmazonServiceResult<AdminDisableProviderForUserRequest,AdminDisableProviderForUserResponse>((AdminDisableProviderForUserRequest)req, (AdminDisableProviderForUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminDisableUser
        internal virtual AdminDisableUserResponse AdminDisableUser(AdminDisableUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminDisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminDisableUserResponseUnmarshaller.Instance;

            return Invoke<AdminDisableUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminDisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminDisableUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminDisableUser">REST API Reference for AdminDisableUser Operation</seealso>
        public virtual void AdminDisableUserAsync(AdminDisableUserRequest request, AmazonServiceCallback<AdminDisableUserRequest, AdminDisableUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminDisableUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminDisableUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminDisableUserRequest,AdminDisableUserResponse> responseObject 
                            = new AmazonServiceResult<AdminDisableUserRequest,AdminDisableUserResponse>((AdminDisableUserRequest)req, (AdminDisableUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminEnableUser
        internal virtual AdminEnableUserResponse AdminEnableUser(AdminEnableUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminEnableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminEnableUserResponseUnmarshaller.Instance;

            return Invoke<AdminEnableUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminEnableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminEnableUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminEnableUser">REST API Reference for AdminEnableUser Operation</seealso>
        public virtual void AdminEnableUserAsync(AdminEnableUserRequest request, AmazonServiceCallback<AdminEnableUserRequest, AdminEnableUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminEnableUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminEnableUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminEnableUserRequest,AdminEnableUserResponse> responseObject 
                            = new AmazonServiceResult<AdminEnableUserRequest,AdminEnableUserResponse>((AdminEnableUserRequest)req, (AdminEnableUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminForgetDevice
        internal virtual AdminForgetDeviceResponse AdminForgetDevice(AdminForgetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminForgetDeviceResponseUnmarshaller.Instance;

            return Invoke<AdminForgetDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminForgetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminForgetDevice">REST API Reference for AdminForgetDevice Operation</seealso>
        public virtual void AdminForgetDeviceAsync(AdminForgetDeviceRequest request, AmazonServiceCallback<AdminForgetDeviceRequest, AdminForgetDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminForgetDeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminForgetDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminForgetDeviceRequest,AdminForgetDeviceResponse> responseObject 
                            = new AmazonServiceResult<AdminForgetDeviceRequest,AdminForgetDeviceResponse>((AdminForgetDeviceRequest)req, (AdminForgetDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminGetDevice
        internal virtual AdminGetDeviceResponse AdminGetDevice(AdminGetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetDeviceResponseUnmarshaller.Instance;

            return Invoke<AdminGetDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetDevice">REST API Reference for AdminGetDevice Operation</seealso>
        public virtual void AdminGetDeviceAsync(AdminGetDeviceRequest request, AmazonServiceCallback<AdminGetDeviceRequest, AdminGetDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminGetDeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminGetDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminGetDeviceRequest,AdminGetDeviceResponse> responseObject 
                            = new AmazonServiceResult<AdminGetDeviceRequest,AdminGetDeviceResponse>((AdminGetDeviceRequest)req, (AdminGetDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminGetUser
        internal virtual AdminGetUserResponse AdminGetUser(AdminGetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminGetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminGetUserResponseUnmarshaller.Instance;

            return Invoke<AdminGetUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminGetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminGetUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminGetUser">REST API Reference for AdminGetUser Operation</seealso>
        public virtual void AdminGetUserAsync(AdminGetUserRequest request, AmazonServiceCallback<AdminGetUserRequest, AdminGetUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminGetUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminGetUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminGetUserRequest,AdminGetUserResponse> responseObject 
                            = new AmazonServiceResult<AdminGetUserRequest,AdminGetUserResponse>((AdminGetUserRequest)req, (AdminGetUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminInitiateAuth
        internal virtual AdminInitiateAuthResponse AdminInitiateAuth(AdminInitiateAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminInitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminInitiateAuthResponseUnmarshaller.Instance;

            return Invoke<AdminInitiateAuthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminInitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminInitiateAuth operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminInitiateAuth">REST API Reference for AdminInitiateAuth Operation</seealso>
        public virtual void AdminInitiateAuthAsync(AdminInitiateAuthRequest request, AmazonServiceCallback<AdminInitiateAuthRequest, AdminInitiateAuthResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminInitiateAuthRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminInitiateAuthResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminInitiateAuthRequest,AdminInitiateAuthResponse> responseObject 
                            = new AmazonServiceResult<AdminInitiateAuthRequest,AdminInitiateAuthResponse>((AdminInitiateAuthRequest)req, (AdminInitiateAuthResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminLinkProviderForUser
        internal virtual AdminLinkProviderForUserResponse AdminLinkProviderForUser(AdminLinkProviderForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminLinkProviderForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminLinkProviderForUserResponseUnmarshaller.Instance;

            return Invoke<AdminLinkProviderForUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminLinkProviderForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminLinkProviderForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminLinkProviderForUser">REST API Reference for AdminLinkProviderForUser Operation</seealso>
        public virtual void AdminLinkProviderForUserAsync(AdminLinkProviderForUserRequest request, AmazonServiceCallback<AdminLinkProviderForUserRequest, AdminLinkProviderForUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminLinkProviderForUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminLinkProviderForUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminLinkProviderForUserRequest,AdminLinkProviderForUserResponse> responseObject 
                            = new AmazonServiceResult<AdminLinkProviderForUserRequest,AdminLinkProviderForUserResponse>((AdminLinkProviderForUserRequest)req, (AdminLinkProviderForUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminListDevices
        internal virtual AdminListDevicesResponse AdminListDevices(AdminListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListDevicesResponseUnmarshaller.Instance;

            return Invoke<AdminListDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListDevices operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListDevices">REST API Reference for AdminListDevices Operation</seealso>
        public virtual void AdminListDevicesAsync(AdminListDevicesRequest request, AmazonServiceCallback<AdminListDevicesRequest, AdminListDevicesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminListDevicesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminListDevicesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminListDevicesRequest,AdminListDevicesResponse> responseObject 
                            = new AmazonServiceResult<AdminListDevicesRequest,AdminListDevicesResponse>((AdminListDevicesRequest)req, (AdminListDevicesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminListGroupsForUser
        internal virtual AdminListGroupsForUserResponse AdminListGroupsForUser(AdminListGroupsForUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListGroupsForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke<AdminListGroupsForUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListGroupsForUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListGroupsForUser">REST API Reference for AdminListGroupsForUser Operation</seealso>
        public virtual void AdminListGroupsForUserAsync(AdminListGroupsForUserRequest request, AmazonServiceCallback<AdminListGroupsForUserRequest, AdminListGroupsForUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminListGroupsForUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminListGroupsForUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminListGroupsForUserRequest,AdminListGroupsForUserResponse> responseObject 
                            = new AmazonServiceResult<AdminListGroupsForUserRequest,AdminListGroupsForUserResponse>((AdminListGroupsForUserRequest)req, (AdminListGroupsForUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminListUserAuthEvents
        internal virtual AdminListUserAuthEventsResponse AdminListUserAuthEvents(AdminListUserAuthEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminListUserAuthEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminListUserAuthEventsResponseUnmarshaller.Instance;

            return Invoke<AdminListUserAuthEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminListUserAuthEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminListUserAuthEvents operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminListUserAuthEvents">REST API Reference for AdminListUserAuthEvents Operation</seealso>
        public virtual void AdminListUserAuthEventsAsync(AdminListUserAuthEventsRequest request, AmazonServiceCallback<AdminListUserAuthEventsRequest, AdminListUserAuthEventsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminListUserAuthEventsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminListUserAuthEventsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminListUserAuthEventsRequest,AdminListUserAuthEventsResponse> responseObject 
                            = new AmazonServiceResult<AdminListUserAuthEventsRequest,AdminListUserAuthEventsResponse>((AdminListUserAuthEventsRequest)req, (AdminListUserAuthEventsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminRemoveUserFromGroup
        internal virtual AdminRemoveUserFromGroupResponse AdminRemoveUserFromGroup(AdminRemoveUserFromGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRemoveUserFromGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke<AdminRemoveUserFromGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminRemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRemoveUserFromGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRemoveUserFromGroup">REST API Reference for AdminRemoveUserFromGroup Operation</seealso>
        public virtual void AdminRemoveUserFromGroupAsync(AdminRemoveUserFromGroupRequest request, AmazonServiceCallback<AdminRemoveUserFromGroupRequest, AdminRemoveUserFromGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminRemoveUserFromGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminRemoveUserFromGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminRemoveUserFromGroupRequest,AdminRemoveUserFromGroupResponse> responseObject 
                            = new AmazonServiceResult<AdminRemoveUserFromGroupRequest,AdminRemoveUserFromGroupResponse>((AdminRemoveUserFromGroupRequest)req, (AdminRemoveUserFromGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminResetUserPassword
        internal virtual AdminResetUserPasswordResponse AdminResetUserPassword(AdminResetUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<AdminResetUserPasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminResetUserPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminResetUserPassword">REST API Reference for AdminResetUserPassword Operation</seealso>
        public virtual void AdminResetUserPasswordAsync(AdminResetUserPasswordRequest request, AmazonServiceCallback<AdminResetUserPasswordRequest, AdminResetUserPasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminResetUserPasswordRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminResetUserPasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminResetUserPasswordRequest,AdminResetUserPasswordResponse> responseObject 
                            = new AmazonServiceResult<AdminResetUserPasswordRequest,AdminResetUserPasswordResponse>((AdminResetUserPasswordRequest)req, (AdminResetUserPasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminRespondToAuthChallenge
        internal virtual AdminRespondToAuthChallengeResponse AdminRespondToAuthChallenge(AdminRespondToAuthChallengeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminRespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminRespondToAuthChallengeResponseUnmarshaller.Instance;

            return Invoke<AdminRespondToAuthChallengeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminRespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminRespondToAuthChallenge operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminRespondToAuthChallenge">REST API Reference for AdminRespondToAuthChallenge Operation</seealso>
        public virtual void AdminRespondToAuthChallengeAsync(AdminRespondToAuthChallengeRequest request, AmazonServiceCallback<AdminRespondToAuthChallengeRequest, AdminRespondToAuthChallengeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminRespondToAuthChallengeRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminRespondToAuthChallengeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminRespondToAuthChallengeRequest,AdminRespondToAuthChallengeResponse> responseObject 
                            = new AmazonServiceResult<AdminRespondToAuthChallengeRequest,AdminRespondToAuthChallengeResponse>((AdminRespondToAuthChallengeRequest)req, (AdminRespondToAuthChallengeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminSetUserMFAPreference
        internal virtual AdminSetUserMFAPreferenceResponse AdminSetUserMFAPreference(AdminSetUserMFAPreferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserMFAPreferenceResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserMFAPreferenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserMFAPreference operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserMFAPreference">REST API Reference for AdminSetUserMFAPreference Operation</seealso>
        public virtual void AdminSetUserMFAPreferenceAsync(AdminSetUserMFAPreferenceRequest request, AmazonServiceCallback<AdminSetUserMFAPreferenceRequest, AdminSetUserMFAPreferenceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminSetUserMFAPreferenceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminSetUserMFAPreferenceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminSetUserMFAPreferenceRequest,AdminSetUserMFAPreferenceResponse> responseObject 
                            = new AmazonServiceResult<AdminSetUserMFAPreferenceRequest,AdminSetUserMFAPreferenceResponse>((AdminSetUserMFAPreferenceRequest)req, (AdminSetUserMFAPreferenceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminSetUserPassword
        internal virtual AdminSetUserPasswordResponse AdminSetUserPassword(AdminSetUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserPasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserPassword">REST API Reference for AdminSetUserPassword Operation</seealso>
        public virtual void AdminSetUserPasswordAsync(AdminSetUserPasswordRequest request, AmazonServiceCallback<AdminSetUserPasswordRequest, AdminSetUserPasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminSetUserPasswordRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminSetUserPasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminSetUserPasswordRequest,AdminSetUserPasswordResponse> responseObject 
                            = new AmazonServiceResult<AdminSetUserPasswordRequest,AdminSetUserPasswordResponse>((AdminSetUserPasswordRequest)req, (AdminSetUserPasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminSetUserSettings
        internal virtual AdminSetUserSettingsResponse AdminSetUserSettings(AdminSetUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminSetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<AdminSetUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminSetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminSetUserSettings operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminSetUserSettings">REST API Reference for AdminSetUserSettings Operation</seealso>
        public virtual void AdminSetUserSettingsAsync(AdminSetUserSettingsRequest request, AmazonServiceCallback<AdminSetUserSettingsRequest, AdminSetUserSettingsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminSetUserSettingsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminSetUserSettingsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminSetUserSettingsRequest,AdminSetUserSettingsResponse> responseObject 
                            = new AmazonServiceResult<AdminSetUserSettingsRequest,AdminSetUserSettingsResponse>((AdminSetUserSettingsRequest)req, (AdminSetUserSettingsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminUpdateAuthEventFeedback
        internal virtual AdminUpdateAuthEventFeedbackResponse AdminUpdateAuthEventFeedback(AdminUpdateAuthEventFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateAuthEventFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateAuthEventFeedback operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateAuthEventFeedback">REST API Reference for AdminUpdateAuthEventFeedback Operation</seealso>
        public virtual void AdminUpdateAuthEventFeedbackAsync(AdminUpdateAuthEventFeedbackRequest request, AmazonServiceCallback<AdminUpdateAuthEventFeedbackRequest, AdminUpdateAuthEventFeedbackResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminUpdateAuthEventFeedbackRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminUpdateAuthEventFeedbackResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminUpdateAuthEventFeedbackRequest,AdminUpdateAuthEventFeedbackResponse> responseObject 
                            = new AmazonServiceResult<AdminUpdateAuthEventFeedbackRequest,AdminUpdateAuthEventFeedbackResponse>((AdminUpdateAuthEventFeedbackRequest)req, (AdminUpdateAuthEventFeedbackResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminUpdateDeviceStatus
        internal virtual AdminUpdateDeviceStatusResponse AdminUpdateDeviceStatus(AdminUpdateDeviceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateDeviceStatusResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateDeviceStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateDeviceStatus operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateDeviceStatus">REST API Reference for AdminUpdateDeviceStatus Operation</seealso>
        public virtual void AdminUpdateDeviceStatusAsync(AdminUpdateDeviceStatusRequest request, AmazonServiceCallback<AdminUpdateDeviceStatusRequest, AdminUpdateDeviceStatusResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminUpdateDeviceStatusRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminUpdateDeviceStatusResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminUpdateDeviceStatusRequest,AdminUpdateDeviceStatusResponse> responseObject 
                            = new AmazonServiceResult<AdminUpdateDeviceStatusRequest,AdminUpdateDeviceStatusResponse>((AdminUpdateDeviceStatusRequest)req, (AdminUpdateDeviceStatusResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminUpdateUserAttributes
        internal virtual AdminUpdateUserAttributesResponse AdminUpdateUserAttributes(AdminUpdateUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<AdminUpdateUserAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUpdateUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUpdateUserAttributes">REST API Reference for AdminUpdateUserAttributes Operation</seealso>
        public virtual void AdminUpdateUserAttributesAsync(AdminUpdateUserAttributesRequest request, AmazonServiceCallback<AdminUpdateUserAttributesRequest, AdminUpdateUserAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminUpdateUserAttributesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminUpdateUserAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminUpdateUserAttributesRequest,AdminUpdateUserAttributesResponse> responseObject 
                            = new AmazonServiceResult<AdminUpdateUserAttributesRequest,AdminUpdateUserAttributesResponse>((AdminUpdateUserAttributesRequest)req, (AdminUpdateUserAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AdminUserGlobalSignOut
        internal virtual AdminUserGlobalSignOutResponse AdminUserGlobalSignOut(AdminUserGlobalSignOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdminUserGlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdminUserGlobalSignOutResponseUnmarshaller.Instance;

            return Invoke<AdminUserGlobalSignOutResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AdminUserGlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdminUserGlobalSignOut operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AdminUserGlobalSignOut">REST API Reference for AdminUserGlobalSignOut Operation</seealso>
        public virtual void AdminUserGlobalSignOutAsync(AdminUserGlobalSignOutRequest request, AmazonServiceCallback<AdminUserGlobalSignOutRequest, AdminUserGlobalSignOutResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AdminUserGlobalSignOutRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AdminUserGlobalSignOutResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AdminUserGlobalSignOutRequest,AdminUserGlobalSignOutResponse> responseObject 
                            = new AmazonServiceResult<AdminUserGlobalSignOutRequest,AdminUserGlobalSignOutResponse>((AdminUserGlobalSignOutRequest)req, (AdminUserGlobalSignOutResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AssociateSoftwareToken
        internal virtual AssociateSoftwareTokenResponse AssociateSoftwareToken(AssociateSoftwareTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSoftwareTokenResponseUnmarshaller.Instance;

            return Invoke<AssociateSoftwareTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSoftwareToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/AssociateSoftwareToken">REST API Reference for AssociateSoftwareToken Operation</seealso>
        public virtual void AssociateSoftwareTokenAsync(AssociateSoftwareTokenRequest request, AmazonServiceCallback<AssociateSoftwareTokenRequest, AssociateSoftwareTokenResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AssociateSoftwareTokenRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AssociateSoftwareTokenResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AssociateSoftwareTokenRequest,AssociateSoftwareTokenResponse> responseObject 
                            = new AmazonServiceResult<AssociateSoftwareTokenRequest,AssociateSoftwareTokenResponse>((AssociateSoftwareTokenRequest)req, (AssociateSoftwareTokenResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ChangePassword
        internal virtual ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        public virtual void ChangePasswordAsync(ChangePasswordRequest request, AmazonServiceCallback<ChangePasswordRequest, ChangePasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ChangePasswordRequest,ChangePasswordResponse> responseObject 
                            = new AmazonServiceResult<ChangePasswordRequest,ChangePasswordResponse>((ChangePasswordRequest)req, (ChangePasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ConfirmDevice
        internal virtual ConfirmDeviceResponse ConfirmDevice(ConfirmDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmDeviceResponseUnmarshaller.Instance;

            return Invoke<ConfirmDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmDevice">REST API Reference for ConfirmDevice Operation</seealso>
        public virtual void ConfirmDeviceAsync(ConfirmDeviceRequest request, AmazonServiceCallback<ConfirmDeviceRequest, ConfirmDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ConfirmDeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ConfirmDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ConfirmDeviceRequest,ConfirmDeviceResponse> responseObject 
                            = new AmazonServiceResult<ConfirmDeviceRequest,ConfirmDeviceResponse>((ConfirmDeviceRequest)req, (ConfirmDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ConfirmForgotPassword
        internal virtual ConfirmForgotPasswordResponse ConfirmForgotPassword(ConfirmForgotPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ConfirmForgotPasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmForgotPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmForgotPassword">REST API Reference for ConfirmForgotPassword Operation</seealso>
        public virtual void ConfirmForgotPasswordAsync(ConfirmForgotPasswordRequest request, AmazonServiceCallback<ConfirmForgotPasswordRequest, ConfirmForgotPasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ConfirmForgotPasswordRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ConfirmForgotPasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ConfirmForgotPasswordRequest,ConfirmForgotPasswordResponse> responseObject 
                            = new AmazonServiceResult<ConfirmForgotPasswordRequest,ConfirmForgotPasswordResponse>((ConfirmForgotPasswordRequest)req, (ConfirmForgotPasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ConfirmSignUp
        internal virtual ConfirmSignUpResponse ConfirmSignUp(ConfirmSignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmSignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;

            return Invoke<ConfirmSignUpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ConfirmSignUp">REST API Reference for ConfirmSignUp Operation</seealso>
        public virtual void ConfirmSignUpAsync(ConfirmSignUpRequest request, AmazonServiceCallback<ConfirmSignUpRequest, ConfirmSignUpResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ConfirmSignUpRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ConfirmSignUpResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ConfirmSignUpRequest,ConfirmSignUpResponse> responseObject 
                            = new AmazonServiceResult<ConfirmSignUpRequest,ConfirmSignUpResponse>((ConfirmSignUpRequest)req, (ConfirmSignUpResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateGroup
        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual void CreateGroupAsync(CreateGroupRequest request, AmazonServiceCallback<CreateGroupRequest, CreateGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateGroupRequest,CreateGroupResponse> responseObject 
                            = new AmazonServiceResult<CreateGroupRequest,CreateGroupResponse>((CreateGroupRequest)req, (CreateGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateIdentityProvider
        internal virtual CreateIdentityProviderResponse CreateIdentityProvider(CreateIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateIdentityProvider">REST API Reference for CreateIdentityProvider Operation</seealso>
        public virtual void CreateIdentityProviderAsync(CreateIdentityProviderRequest request, AmazonServiceCallback<CreateIdentityProviderRequest, CreateIdentityProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateIdentityProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateIdentityProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateIdentityProviderRequest,CreateIdentityProviderResponse> responseObject 
                            = new AmazonServiceResult<CreateIdentityProviderRequest,CreateIdentityProviderResponse>((CreateIdentityProviderRequest)req, (CreateIdentityProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateResourceServer
        internal virtual CreateResourceServerResponse CreateResourceServer(CreateResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceServerResponseUnmarshaller.Instance;

            return Invoke<CreateResourceServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateResourceServer">REST API Reference for CreateResourceServer Operation</seealso>
        public virtual void CreateResourceServerAsync(CreateResourceServerRequest request, AmazonServiceCallback<CreateResourceServerRequest, CreateResourceServerResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateResourceServerRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateResourceServerResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateResourceServerRequest,CreateResourceServerResponse> responseObject 
                            = new AmazonServiceResult<CreateResourceServerRequest,CreateResourceServerResponse>((CreateResourceServerRequest)req, (CreateResourceServerResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUserImportJob
        internal virtual CreateUserImportJobResponse CreateUserImportJob(CreateUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateUserImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserImportJob">REST API Reference for CreateUserImportJob Operation</seealso>
        public virtual void CreateUserImportJobAsync(CreateUserImportJobRequest request, AmazonServiceCallback<CreateUserImportJobRequest, CreateUserImportJobResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateUserImportJobRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateUserImportJobResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserImportJobRequest,CreateUserImportJobResponse> responseObject 
                            = new AmazonServiceResult<CreateUserImportJobRequest,CreateUserImportJobResponse>((CreateUserImportJobRequest)req, (CreateUserImportJobResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUserPool
        internal virtual CreateUserPoolResponse CreateUserPool(CreateUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPool">REST API Reference for CreateUserPool Operation</seealso>
        public virtual void CreateUserPoolAsync(CreateUserPoolRequest request, AmazonServiceCallback<CreateUserPoolRequest, CreateUserPoolResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateUserPoolRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateUserPoolResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserPoolRequest,CreateUserPoolResponse> responseObject 
                            = new AmazonServiceResult<CreateUserPoolRequest,CreateUserPoolResponse>((CreateUserPoolRequest)req, (CreateUserPoolResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUserPoolClient
        internal virtual CreateUserPoolClientResponse CreateUserPoolClient(CreateUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolClientResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolClient">REST API Reference for CreateUserPoolClient Operation</seealso>
        public virtual void CreateUserPoolClientAsync(CreateUserPoolClientRequest request, AmazonServiceCallback<CreateUserPoolClientRequest, CreateUserPoolClientResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateUserPoolClientRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateUserPoolClientResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserPoolClientRequest,CreateUserPoolClientResponse> responseObject 
                            = new AmazonServiceResult<CreateUserPoolClientRequest,CreateUserPoolClientResponse>((CreateUserPoolClientRequest)req, (CreateUserPoolClientResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUserPoolDomain
        internal virtual CreateUserPoolDomainResponse CreateUserPoolDomain(CreateUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<CreateUserPoolDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/CreateUserPoolDomain">REST API Reference for CreateUserPoolDomain Operation</seealso>
        public virtual void CreateUserPoolDomainAsync(CreateUserPoolDomainRequest request, AmazonServiceCallback<CreateUserPoolDomainRequest, CreateUserPoolDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateUserPoolDomainRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateUserPoolDomainResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserPoolDomainRequest,CreateUserPoolDomainResponse> responseObject 
                            = new AmazonServiceResult<CreateUserPoolDomainRequest,CreateUserPoolDomainResponse>((CreateUserPoolDomainRequest)req, (CreateUserPoolDomainResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteGroup
        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual void DeleteGroupAsync(DeleteGroupRequest request, AmazonServiceCallback<DeleteGroupRequest, DeleteGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteGroupRequest,DeleteGroupResponse> responseObject 
                            = new AmazonServiceResult<DeleteGroupRequest,DeleteGroupResponse>((DeleteGroupRequest)req, (DeleteGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteIdentityProvider
        internal virtual DeleteIdentityProviderResponse DeleteIdentityProvider(DeleteIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteIdentityProvider">REST API Reference for DeleteIdentityProvider Operation</seealso>
        public virtual void DeleteIdentityProviderAsync(DeleteIdentityProviderRequest request, AmazonServiceCallback<DeleteIdentityProviderRequest, DeleteIdentityProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteIdentityProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteIdentityProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteIdentityProviderRequest,DeleteIdentityProviderResponse> responseObject 
                            = new AmazonServiceResult<DeleteIdentityProviderRequest,DeleteIdentityProviderResponse>((DeleteIdentityProviderRequest)req, (DeleteIdentityProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteResourceServer
        internal virtual DeleteResourceServerResponse DeleteResourceServer(DeleteResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceServerResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteResourceServer">REST API Reference for DeleteResourceServer Operation</seealso>
        public virtual void DeleteResourceServerAsync(DeleteResourceServerRequest request, AmazonServiceCallback<DeleteResourceServerRequest, DeleteResourceServerResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteResourceServerRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteResourceServerResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteResourceServerRequest,DeleteResourceServerResponse> responseObject 
                            = new AmazonServiceResult<DeleteResourceServerRequest,DeleteResourceServerResponse>((DeleteResourceServerRequest)req, (DeleteResourceServerResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUser
        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual void DeleteUserAsync(DeleteUserRequest request, AmazonServiceCallback<DeleteUserRequest, DeleteUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserRequest,DeleteUserResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserRequest,DeleteUserResponse>((DeleteUserRequest)req, (DeleteUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserAttributes
        internal virtual DeleteUserAttributesResponse DeleteUserAttributes(DeleteUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;

            return Invoke<DeleteUserAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserAttributes">REST API Reference for DeleteUserAttributes Operation</seealso>
        public virtual void DeleteUserAttributesAsync(DeleteUserAttributesRequest request, AmazonServiceCallback<DeleteUserAttributesRequest, DeleteUserAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteUserAttributesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteUserAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserAttributesRequest,DeleteUserAttributesResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserAttributesRequest,DeleteUserAttributesResponse>((DeleteUserAttributesRequest)req, (DeleteUserAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserPool
        internal virtual DeleteUserPoolResponse DeleteUserPool(DeleteUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPool">REST API Reference for DeleteUserPool Operation</seealso>
        public virtual void DeleteUserPoolAsync(DeleteUserPoolRequest request, AmazonServiceCallback<DeleteUserPoolRequest, DeleteUserPoolResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteUserPoolRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteUserPoolResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserPoolRequest,DeleteUserPoolResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserPoolRequest,DeleteUserPoolResponse>((DeleteUserPoolRequest)req, (DeleteUserPoolResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserPoolClient
        internal virtual DeleteUserPoolClientResponse DeleteUserPoolClient(DeleteUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolClientResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolClient">REST API Reference for DeleteUserPoolClient Operation</seealso>
        public virtual void DeleteUserPoolClientAsync(DeleteUserPoolClientRequest request, AmazonServiceCallback<DeleteUserPoolClientRequest, DeleteUserPoolClientResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteUserPoolClientRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteUserPoolClientResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserPoolClientRequest,DeleteUserPoolClientResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserPoolClientRequest,DeleteUserPoolClientResponse>((DeleteUserPoolClientRequest)req, (DeleteUserPoolClientResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserPoolDomain
        internal virtual DeleteUserPoolDomainResponse DeleteUserPoolDomain(DeleteUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPoolDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DeleteUserPoolDomain">REST API Reference for DeleteUserPoolDomain Operation</seealso>
        public virtual void DeleteUserPoolDomainAsync(DeleteUserPoolDomainRequest request, AmazonServiceCallback<DeleteUserPoolDomainRequest, DeleteUserPoolDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteUserPoolDomainRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteUserPoolDomainResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserPoolDomainRequest,DeleteUserPoolDomainResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserPoolDomainRequest,DeleteUserPoolDomainResponse>((DeleteUserPoolDomainRequest)req, (DeleteUserPoolDomainResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeIdentityProvider
        internal virtual DescribeIdentityProviderResponse DescribeIdentityProvider(DescribeIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeIdentityProvider">REST API Reference for DescribeIdentityProvider Operation</seealso>
        public virtual void DescribeIdentityProviderAsync(DescribeIdentityProviderRequest request, AmazonServiceCallback<DescribeIdentityProviderRequest, DescribeIdentityProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeIdentityProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeIdentityProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeIdentityProviderRequest,DescribeIdentityProviderResponse> responseObject 
                            = new AmazonServiceResult<DescribeIdentityProviderRequest,DescribeIdentityProviderResponse>((DescribeIdentityProviderRequest)req, (DescribeIdentityProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeResourceServer
        internal virtual DescribeResourceServerResponse DescribeResourceServer(DescribeResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourceServerResponseUnmarshaller.Instance;

            return Invoke<DescribeResourceServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeResourceServer">REST API Reference for DescribeResourceServer Operation</seealso>
        public virtual void DescribeResourceServerAsync(DescribeResourceServerRequest request, AmazonServiceCallback<DescribeResourceServerRequest, DescribeResourceServerResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeResourceServerRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeResourceServerResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeResourceServerRequest,DescribeResourceServerResponse> responseObject 
                            = new AmazonServiceResult<DescribeResourceServerRequest,DescribeResourceServerResponse>((DescribeResourceServerRequest)req, (DescribeResourceServerResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeRiskConfiguration
        internal virtual DescribeRiskConfigurationResponse DescribeRiskConfiguration(DescribeRiskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRiskConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRiskConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRiskConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeRiskConfiguration">REST API Reference for DescribeRiskConfiguration Operation</seealso>
        public virtual void DescribeRiskConfigurationAsync(DescribeRiskConfigurationRequest request, AmazonServiceCallback<DescribeRiskConfigurationRequest, DescribeRiskConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeRiskConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeRiskConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeRiskConfigurationRequest,DescribeRiskConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DescribeRiskConfigurationRequest,DescribeRiskConfigurationResponse>((DescribeRiskConfigurationRequest)req, (DescribeRiskConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeUserImportJob
        internal virtual DescribeUserImportJobResponse DescribeUserImportJob(DescribeUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeUserImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserImportJob">REST API Reference for DescribeUserImportJob Operation</seealso>
        public virtual void DescribeUserImportJobAsync(DescribeUserImportJobRequest request, AmazonServiceCallback<DescribeUserImportJobRequest, DescribeUserImportJobResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeUserImportJobRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeUserImportJobResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeUserImportJobRequest,DescribeUserImportJobResponse> responseObject 
                            = new AmazonServiceResult<DescribeUserImportJobRequest,DescribeUserImportJobResponse>((DescribeUserImportJobRequest)req, (DescribeUserImportJobResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeUserPool
        internal virtual DescribeUserPoolResponse DescribeUserPool(DescribeUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPool">REST API Reference for DescribeUserPool Operation</seealso>
        public virtual void DescribeUserPoolAsync(DescribeUserPoolRequest request, AmazonServiceCallback<DescribeUserPoolRequest, DescribeUserPoolResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeUserPoolRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeUserPoolResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeUserPoolRequest,DescribeUserPoolResponse> responseObject 
                            = new AmazonServiceResult<DescribeUserPoolRequest,DescribeUserPoolResponse>((DescribeUserPoolRequest)req, (DescribeUserPoolResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeUserPoolClient
        internal virtual DescribeUserPoolClientResponse DescribeUserPoolClient(DescribeUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolClientResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolClient">REST API Reference for DescribeUserPoolClient Operation</seealso>
        public virtual void DescribeUserPoolClientAsync(DescribeUserPoolClientRequest request, AmazonServiceCallback<DescribeUserPoolClientRequest, DescribeUserPoolClientResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeUserPoolClientRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeUserPoolClientResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeUserPoolClientRequest,DescribeUserPoolClientResponse> responseObject 
                            = new AmazonServiceResult<DescribeUserPoolClientRequest,DescribeUserPoolClientResponse>((DescribeUserPoolClientRequest)req, (DescribeUserPoolClientResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DescribeUserPoolDomain
        internal virtual DescribeUserPoolDomainResponse DescribeUserPoolDomain(DescribeUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeUserPoolDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/DescribeUserPoolDomain">REST API Reference for DescribeUserPoolDomain Operation</seealso>
        public virtual void DescribeUserPoolDomainAsync(DescribeUserPoolDomainRequest request, AmazonServiceCallback<DescribeUserPoolDomainRequest, DescribeUserPoolDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DescribeUserPoolDomainRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DescribeUserPoolDomainResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DescribeUserPoolDomainRequest,DescribeUserPoolDomainResponse> responseObject 
                            = new AmazonServiceResult<DescribeUserPoolDomainRequest,DescribeUserPoolDomainResponse>((DescribeUserPoolDomainRequest)req, (DescribeUserPoolDomainResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ForgetDevice
        internal virtual ForgetDeviceResponse ForgetDevice(ForgetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgetDeviceResponseUnmarshaller.Instance;

            return Invoke<ForgetDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ForgetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgetDevice">REST API Reference for ForgetDevice Operation</seealso>
        public virtual void ForgetDeviceAsync(ForgetDeviceRequest request, AmazonServiceCallback<ForgetDeviceRequest, ForgetDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ForgetDeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ForgetDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ForgetDeviceRequest,ForgetDeviceResponse> responseObject 
                            = new AmazonServiceResult<ForgetDeviceRequest,ForgetDeviceResponse>((ForgetDeviceRequest)req, (ForgetDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ForgotPassword
        internal virtual ForgotPasswordResponse ForgotPassword(ForgotPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ForgotPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ForgotPasswordResponseUnmarshaller.Instance;

            return Invoke<ForgotPasswordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ForgotPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ForgotPassword operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ForgotPassword">REST API Reference for ForgotPassword Operation</seealso>
        public virtual void ForgotPasswordAsync(ForgotPasswordRequest request, AmazonServiceCallback<ForgotPasswordRequest, ForgotPasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ForgotPasswordRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ForgotPasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ForgotPasswordRequest,ForgotPasswordResponse> responseObject 
                            = new AmazonServiceResult<ForgotPasswordRequest,ForgotPasswordResponse>((ForgotPasswordRequest)req, (ForgotPasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetCSVHeader
        internal virtual GetCSVHeaderResponse GetCSVHeader(GetCSVHeaderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCSVHeaderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCSVHeaderResponseUnmarshaller.Instance;

            return Invoke<GetCSVHeaderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCSVHeader operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCSVHeader operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetCSVHeader">REST API Reference for GetCSVHeader Operation</seealso>
        public virtual void GetCSVHeaderAsync(GetCSVHeaderRequest request, AmazonServiceCallback<GetCSVHeaderRequest, GetCSVHeaderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetCSVHeaderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetCSVHeaderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetCSVHeaderRequest,GetCSVHeaderResponse> responseObject 
                            = new AmazonServiceResult<GetCSVHeaderRequest,GetCSVHeaderResponse>((GetCSVHeaderRequest)req, (GetCSVHeaderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetDevice
        internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevice operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual void GetDeviceAsync(GetDeviceRequest request, AmazonServiceCallback<GetDeviceRequest, GetDeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetDeviceRequest,GetDeviceResponse> responseObject 
                            = new AmazonServiceResult<GetDeviceRequest,GetDeviceResponse>((GetDeviceRequest)req, (GetDeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetGroup
        internal virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual void GetGroupAsync(GetGroupRequest request, AmazonServiceCallback<GetGroupRequest, GetGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetGroupRequest,GetGroupResponse> responseObject 
                            = new AmazonServiceResult<GetGroupRequest,GetGroupResponse>((GetGroupRequest)req, (GetGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetIdentityProviderByIdentifier
        internal virtual GetIdentityProviderByIdentifierResponse GetIdentityProviderByIdentifier(GetIdentityProviderByIdentifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityProviderByIdentifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityProviderByIdentifierResponseUnmarshaller.Instance;

            return Invoke<GetIdentityProviderByIdentifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityProviderByIdentifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityProviderByIdentifier operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetIdentityProviderByIdentifier">REST API Reference for GetIdentityProviderByIdentifier Operation</seealso>
        public virtual void GetIdentityProviderByIdentifierAsync(GetIdentityProviderByIdentifierRequest request, AmazonServiceCallback<GetIdentityProviderByIdentifierRequest, GetIdentityProviderByIdentifierResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetIdentityProviderByIdentifierRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetIdentityProviderByIdentifierResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetIdentityProviderByIdentifierRequest,GetIdentityProviderByIdentifierResponse> responseObject 
                            = new AmazonServiceResult<GetIdentityProviderByIdentifierRequest,GetIdentityProviderByIdentifierResponse>((GetIdentityProviderByIdentifierRequest)req, (GetIdentityProviderByIdentifierResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetSigningCertificate
        internal virtual GetSigningCertificateResponse GetSigningCertificate(GetSigningCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<GetSigningCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningCertificate operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetSigningCertificate">REST API Reference for GetSigningCertificate Operation</seealso>
        public virtual void GetSigningCertificateAsync(GetSigningCertificateRequest request, AmazonServiceCallback<GetSigningCertificateRequest, GetSigningCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetSigningCertificateRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetSigningCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetSigningCertificateRequest,GetSigningCertificateResponse> responseObject 
                            = new AmazonServiceResult<GetSigningCertificateRequest,GetSigningCertificateResponse>((GetSigningCertificateRequest)req, (GetSigningCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetUICustomization
        internal virtual GetUICustomizationResponse GetUICustomization(GetUICustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUICustomizationResponseUnmarshaller.Instance;

            return Invoke<GetUICustomizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUICustomization operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUICustomization">REST API Reference for GetUICustomization Operation</seealso>
        public virtual void GetUICustomizationAsync(GetUICustomizationRequest request, AmazonServiceCallback<GetUICustomizationRequest, GetUICustomizationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetUICustomizationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetUICustomizationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUICustomizationRequest,GetUICustomizationResponse> responseObject 
                            = new AmazonServiceResult<GetUICustomizationRequest,GetUICustomizationResponse>((GetUICustomizationRequest)req, (GetUICustomizationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetUser
        internal virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual void GetUserAsync(GetUserRequest request, AmazonServiceCallback<GetUserRequest, GetUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUserRequest,GetUserResponse> responseObject 
                            = new AmazonServiceResult<GetUserRequest,GetUserResponse>((GetUserRequest)req, (GetUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetUserAttributeVerificationCode
        internal virtual GetUserAttributeVerificationCodeResponse GetUserAttributeVerificationCode(GetUserAttributeVerificationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserAttributeVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;

            return Invoke<GetUserAttributeVerificationCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserAttributeVerificationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserAttributeVerificationCode operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserAttributeVerificationCode">REST API Reference for GetUserAttributeVerificationCode Operation</seealso>
        public virtual void GetUserAttributeVerificationCodeAsync(GetUserAttributeVerificationCodeRequest request, AmazonServiceCallback<GetUserAttributeVerificationCodeRequest, GetUserAttributeVerificationCodeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetUserAttributeVerificationCodeRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetUserAttributeVerificationCodeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUserAttributeVerificationCodeRequest,GetUserAttributeVerificationCodeResponse> responseObject 
                            = new AmazonServiceResult<GetUserAttributeVerificationCodeRequest,GetUserAttributeVerificationCodeResponse>((GetUserAttributeVerificationCodeRequest)req, (GetUserAttributeVerificationCodeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetUserPoolMfaConfig
        internal virtual GetUserPoolMfaConfigResponse GetUserPoolMfaConfig(GetUserPoolMfaConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return Invoke<GetUserPoolMfaConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPoolMfaConfig operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GetUserPoolMfaConfig">REST API Reference for GetUserPoolMfaConfig Operation</seealso>
        public virtual void GetUserPoolMfaConfigAsync(GetUserPoolMfaConfigRequest request, AmazonServiceCallback<GetUserPoolMfaConfigRequest, GetUserPoolMfaConfigResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetUserPoolMfaConfigRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetUserPoolMfaConfigResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUserPoolMfaConfigRequest,GetUserPoolMfaConfigResponse> responseObject 
                            = new AmazonServiceResult<GetUserPoolMfaConfigRequest,GetUserPoolMfaConfigResponse>((GetUserPoolMfaConfigRequest)req, (GetUserPoolMfaConfigResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GlobalSignOut
        internal virtual GlobalSignOutResponse GlobalSignOut(GlobalSignOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GlobalSignOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GlobalSignOutResponseUnmarshaller.Instance;

            return Invoke<GlobalSignOutResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GlobalSignOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GlobalSignOut operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/GlobalSignOut">REST API Reference for GlobalSignOut Operation</seealso>
        public virtual void GlobalSignOutAsync(GlobalSignOutRequest request, AmazonServiceCallback<GlobalSignOutRequest, GlobalSignOutResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GlobalSignOutRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GlobalSignOutResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GlobalSignOutRequest,GlobalSignOutResponse> responseObject 
                            = new AmazonServiceResult<GlobalSignOutRequest,GlobalSignOutResponse>((GlobalSignOutRequest)req, (GlobalSignOutResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  InitiateAuth
        internal virtual InitiateAuthResponse InitiateAuth(InitiateAuthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateAuthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateAuthResponseUnmarshaller.Instance;

            return Invoke<InitiateAuthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateAuth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateAuth operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/InitiateAuth">REST API Reference for InitiateAuth Operation</seealso>
        public virtual void InitiateAuthAsync(InitiateAuthRequest request, AmazonServiceCallback<InitiateAuthRequest, InitiateAuthResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = InitiateAuthRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = InitiateAuthResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<InitiateAuthRequest,InitiateAuthResponse> responseObject 
                            = new AmazonServiceResult<InitiateAuthRequest,InitiateAuthResponse>((InitiateAuthRequest)req, (InitiateAuthResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListDevices
        internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual void ListDevicesAsync(ListDevicesRequest request, AmazonServiceCallback<ListDevicesRequest, ListDevicesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListDevicesRequest,ListDevicesResponse> responseObject 
                            = new AmazonServiceResult<ListDevicesRequest,ListDevicesResponse>((ListDevicesRequest)req, (ListDevicesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListGroups
        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual void ListGroupsAsync(ListGroupsRequest request, AmazonServiceCallback<ListGroupsRequest, ListGroupsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListGroupsRequest,ListGroupsResponse> responseObject 
                            = new AmazonServiceResult<ListGroupsRequest,ListGroupsResponse>((ListGroupsRequest)req, (ListGroupsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListIdentityProviders
        internal virtual ListIdentityProvidersResponse ListIdentityProviders(ListIdentityProvidersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;

            return Invoke<ListIdentityProvidersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityProviders operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListIdentityProviders">REST API Reference for ListIdentityProviders Operation</seealso>
        public virtual void ListIdentityProvidersAsync(ListIdentityProvidersRequest request, AmazonServiceCallback<ListIdentityProvidersRequest, ListIdentityProvidersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListIdentityProvidersRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListIdentityProvidersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListIdentityProvidersRequest,ListIdentityProvidersResponse> responseObject 
                            = new AmazonServiceResult<ListIdentityProvidersRequest,ListIdentityProvidersResponse>((ListIdentityProvidersRequest)req, (ListIdentityProvidersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListResourceServers
        internal virtual ListResourceServersResponse ListResourceServers(ListResourceServersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceServersResponseUnmarshaller.Instance;

            return Invoke<ListResourceServersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceServers operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListResourceServers">REST API Reference for ListResourceServers Operation</seealso>
        public virtual void ListResourceServersAsync(ListResourceServersRequest request, AmazonServiceCallback<ListResourceServersRequest, ListResourceServersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListResourceServersRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListResourceServersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListResourceServersRequest,ListResourceServersResponse> responseObject 
                            = new AmazonServiceResult<ListResourceServersRequest,ListResourceServersResponse>((ListResourceServersRequest)req, (ListResourceServersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListTagsForResource
        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual void ListTagsForResourceAsync(ListTagsForResourceRequest request, AmazonServiceCallback<ListTagsForResourceRequest, ListTagsForResourceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListTagsForResourceRequest,ListTagsForResourceResponse> responseObject 
                            = new AmazonServiceResult<ListTagsForResourceRequest,ListTagsForResourceResponse>((ListTagsForResourceRequest)req, (ListTagsForResourceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListUserImportJobs
        internal virtual ListUserImportJobsResponse ListUserImportJobs(ListUserImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListUserImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserImportJobs operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserImportJobs">REST API Reference for ListUserImportJobs Operation</seealso>
        public virtual void ListUserImportJobsAsync(ListUserImportJobsRequest request, AmazonServiceCallback<ListUserImportJobsRequest, ListUserImportJobsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListUserImportJobsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListUserImportJobsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUserImportJobsRequest,ListUserImportJobsResponse> responseObject 
                            = new AmazonServiceResult<ListUserImportJobsRequest,ListUserImportJobsResponse>((ListUserImportJobsRequest)req, (ListUserImportJobsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListUserPoolClients
        internal virtual ListUserPoolClientsResponse ListUserPoolClients(ListUserPoolClientsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolClientsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPoolClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoolClients operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPoolClients">REST API Reference for ListUserPoolClients Operation</seealso>
        public virtual void ListUserPoolClientsAsync(ListUserPoolClientsRequest request, AmazonServiceCallback<ListUserPoolClientsRequest, ListUserPoolClientsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListUserPoolClientsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListUserPoolClientsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUserPoolClientsRequest,ListUserPoolClientsResponse> responseObject 
                            = new AmazonServiceResult<ListUserPoolClientsRequest,ListUserPoolClientsResponse>((ListUserPoolClientsRequest)req, (ListUserPoolClientsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListUserPools
        internal virtual ListUserPoolsResponse ListUserPools(ListUserPoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserPoolsResponseUnmarshaller.Instance;

            return Invoke<ListUserPoolsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPools operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUserPools">REST API Reference for ListUserPools Operation</seealso>
        public virtual void ListUserPoolsAsync(ListUserPoolsRequest request, AmazonServiceCallback<ListUserPoolsRequest, ListUserPoolsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListUserPoolsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListUserPoolsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUserPoolsRequest,ListUserPoolsResponse> responseObject 
                            = new AmazonServiceResult<ListUserPoolsRequest,ListUserPoolsResponse>((ListUserPoolsRequest)req, (ListUserPoolsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListUsers
        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual void ListUsersAsync(ListUsersRequest request, AmazonServiceCallback<ListUsersRequest, ListUsersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUsersRequest,ListUsersResponse> responseObject 
                            = new AmazonServiceResult<ListUsersRequest,ListUsersResponse>((ListUsersRequest)req, (ListUsersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListUsersInGroup
        internal virtual ListUsersInGroupResponse ListUsersInGroup(ListUsersInGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersInGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersInGroupResponseUnmarshaller.Instance;

            return Invoke<ListUsersInGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsersInGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsersInGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ListUsersInGroup">REST API Reference for ListUsersInGroup Operation</seealso>
        public virtual void ListUsersInGroupAsync(ListUsersInGroupRequest request, AmazonServiceCallback<ListUsersInGroupRequest, ListUsersInGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListUsersInGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListUsersInGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUsersInGroupRequest,ListUsersInGroupResponse> responseObject 
                            = new AmazonServiceResult<ListUsersInGroupRequest,ListUsersInGroupResponse>((ListUsersInGroupRequest)req, (ListUsersInGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ResendConfirmationCode
        internal virtual ResendConfirmationCodeResponse ResendConfirmationCode(ResendConfirmationCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResendConfirmationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;

            return Invoke<ResendConfirmationCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResendConfirmationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendConfirmationCode operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/ResendConfirmationCode">REST API Reference for ResendConfirmationCode Operation</seealso>
        public virtual void ResendConfirmationCodeAsync(ResendConfirmationCodeRequest request, AmazonServiceCallback<ResendConfirmationCodeRequest, ResendConfirmationCodeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ResendConfirmationCodeRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ResendConfirmationCodeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ResendConfirmationCodeRequest,ResendConfirmationCodeResponse> responseObject 
                            = new AmazonServiceResult<ResendConfirmationCodeRequest,ResendConfirmationCodeResponse>((ResendConfirmationCodeRequest)req, (ResendConfirmationCodeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  RespondToAuthChallenge
        internal virtual RespondToAuthChallengeResponse RespondToAuthChallenge(RespondToAuthChallengeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondToAuthChallengeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondToAuthChallengeResponseUnmarshaller.Instance;

            return Invoke<RespondToAuthChallengeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RespondToAuthChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondToAuthChallenge operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/RespondToAuthChallenge">REST API Reference for RespondToAuthChallenge Operation</seealso>
        public virtual void RespondToAuthChallengeAsync(RespondToAuthChallengeRequest request, AmazonServiceCallback<RespondToAuthChallengeRequest, RespondToAuthChallengeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = RespondToAuthChallengeRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = RespondToAuthChallengeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RespondToAuthChallengeRequest,RespondToAuthChallengeResponse> responseObject 
                            = new AmazonServiceResult<RespondToAuthChallengeRequest,RespondToAuthChallengeResponse>((RespondToAuthChallengeRequest)req, (RespondToAuthChallengeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SetRiskConfiguration
        internal virtual SetRiskConfigurationResponse SetRiskConfiguration(SetRiskConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRiskConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRiskConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetRiskConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetRiskConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRiskConfiguration operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetRiskConfiguration">REST API Reference for SetRiskConfiguration Operation</seealso>
        public virtual void SetRiskConfigurationAsync(SetRiskConfigurationRequest request, AmazonServiceCallback<SetRiskConfigurationRequest, SetRiskConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SetRiskConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SetRiskConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetRiskConfigurationRequest,SetRiskConfigurationResponse> responseObject 
                            = new AmazonServiceResult<SetRiskConfigurationRequest,SetRiskConfigurationResponse>((SetRiskConfigurationRequest)req, (SetRiskConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SetUICustomization
        internal virtual SetUICustomizationResponse SetUICustomization(SetUICustomizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUICustomizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUICustomizationResponseUnmarshaller.Instance;

            return Invoke<SetUICustomizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUICustomization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUICustomization operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUICustomization">REST API Reference for SetUICustomization Operation</seealso>
        public virtual void SetUICustomizationAsync(SetUICustomizationRequest request, AmazonServiceCallback<SetUICustomizationRequest, SetUICustomizationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SetUICustomizationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SetUICustomizationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetUICustomizationRequest,SetUICustomizationResponse> responseObject 
                            = new AmazonServiceResult<SetUICustomizationRequest,SetUICustomizationResponse>((SetUICustomizationRequest)req, (SetUICustomizationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SetUserMFAPreference
        internal virtual SetUserMFAPreferenceResponse SetUserMFAPreference(SetUserMFAPreferenceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserMFAPreferenceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserMFAPreferenceResponseUnmarshaller.Instance;

            return Invoke<SetUserMFAPreferenceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserMFAPreference operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserMFAPreference operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserMFAPreference">REST API Reference for SetUserMFAPreference Operation</seealso>
        public virtual void SetUserMFAPreferenceAsync(SetUserMFAPreferenceRequest request, AmazonServiceCallback<SetUserMFAPreferenceRequest, SetUserMFAPreferenceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SetUserMFAPreferenceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SetUserMFAPreferenceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetUserMFAPreferenceRequest,SetUserMFAPreferenceResponse> responseObject 
                            = new AmazonServiceResult<SetUserMFAPreferenceRequest,SetUserMFAPreferenceResponse>((SetUserMFAPreferenceRequest)req, (SetUserMFAPreferenceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SetUserPoolMfaConfig
        internal virtual SetUserPoolMfaConfigResponse SetUserPoolMfaConfig(SetUserPoolMfaConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserPoolMfaConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserPoolMfaConfigResponseUnmarshaller.Instance;

            return Invoke<SetUserPoolMfaConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserPoolMfaConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserPoolMfaConfig operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserPoolMfaConfig">REST API Reference for SetUserPoolMfaConfig Operation</seealso>
        public virtual void SetUserPoolMfaConfigAsync(SetUserPoolMfaConfigRequest request, AmazonServiceCallback<SetUserPoolMfaConfigRequest, SetUserPoolMfaConfigResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SetUserPoolMfaConfigRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SetUserPoolMfaConfigResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetUserPoolMfaConfigRequest,SetUserPoolMfaConfigResponse> responseObject 
                            = new AmazonServiceResult<SetUserPoolMfaConfigRequest,SetUserPoolMfaConfigResponse>((SetUserPoolMfaConfigRequest)req, (SetUserPoolMfaConfigResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SetUserSettings
        internal virtual SetUserSettingsResponse SetUserSettings(SetUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<SetUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetUserSettings operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SetUserSettings">REST API Reference for SetUserSettings Operation</seealso>
        public virtual void SetUserSettingsAsync(SetUserSettingsRequest request, AmazonServiceCallback<SetUserSettingsRequest, SetUserSettingsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SetUserSettingsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SetUserSettingsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetUserSettingsRequest,SetUserSettingsResponse> responseObject 
                            = new AmazonServiceResult<SetUserSettingsRequest,SetUserSettingsResponse>((SetUserSettingsRequest)req, (SetUserSettingsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SignUp
        internal virtual SignUpResponse SignUp(SignUpRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignUpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignUpResponseUnmarshaller.Instance;

            return Invoke<SignUpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SignUp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignUp operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/SignUp">REST API Reference for SignUp Operation</seealso>
        public virtual void SignUpAsync(SignUpRequest request, AmazonServiceCallback<SignUpRequest, SignUpResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SignUpRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SignUpResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SignUpRequest,SignUpResponse> responseObject 
                            = new AmazonServiceResult<SignUpRequest,SignUpResponse>((SignUpRequest)req, (SignUpResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StartUserImportJob
        internal virtual StartUserImportJobResponse StartUserImportJob(StartUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartUserImportJobResponseUnmarshaller.Instance;

            return Invoke<StartUserImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StartUserImportJob">REST API Reference for StartUserImportJob Operation</seealso>
        public virtual void StartUserImportJobAsync(StartUserImportJobRequest request, AmazonServiceCallback<StartUserImportJobRequest, StartUserImportJobResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StartUserImportJobRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StartUserImportJobResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StartUserImportJobRequest,StartUserImportJobResponse> responseObject 
                            = new AmazonServiceResult<StartUserImportJobRequest,StartUserImportJobResponse>((StartUserImportJobRequest)req, (StartUserImportJobResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  StopUserImportJob
        internal virtual StopUserImportJobResponse StopUserImportJob(StopUserImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopUserImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopUserImportJobResponseUnmarshaller.Instance;

            return Invoke<StopUserImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopUserImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopUserImportJob operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/StopUserImportJob">REST API Reference for StopUserImportJob Operation</seealso>
        public virtual void StopUserImportJobAsync(StopUserImportJobRequest request, AmazonServiceCallback<StopUserImportJobRequest, StopUserImportJobResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = StopUserImportJobRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = StopUserImportJobResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<StopUserImportJobRequest,StopUserImportJobResponse> responseObject 
                            = new AmazonServiceResult<StopUserImportJobRequest,StopUserImportJobResponse>((StopUserImportJobRequest)req, (StopUserImportJobResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  TagResource
        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual void TagResourceAsync(TagResourceRequest request, AmazonServiceCallback<TagResourceRequest, TagResourceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<TagResourceRequest,TagResourceResponse> responseObject 
                            = new AmazonServiceResult<TagResourceRequest,TagResourceResponse>((TagResourceRequest)req, (TagResourceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UntagResource
        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual void UntagResourceAsync(UntagResourceRequest request, AmazonServiceCallback<UntagResourceRequest, UntagResourceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UntagResourceRequest,UntagResourceResponse> responseObject 
                            = new AmazonServiceResult<UntagResourceRequest,UntagResourceResponse>((UntagResourceRequest)req, (UntagResourceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateAuthEventFeedback
        internal virtual UpdateAuthEventFeedbackResponse UpdateAuthEventFeedback(UpdateAuthEventFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthEventFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthEventFeedbackResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthEventFeedbackResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthEventFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthEventFeedback operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateAuthEventFeedback">REST API Reference for UpdateAuthEventFeedback Operation</seealso>
        public virtual void UpdateAuthEventFeedbackAsync(UpdateAuthEventFeedbackRequest request, AmazonServiceCallback<UpdateAuthEventFeedbackRequest, UpdateAuthEventFeedbackResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateAuthEventFeedbackRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateAuthEventFeedbackResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateAuthEventFeedbackRequest,UpdateAuthEventFeedbackResponse> responseObject 
                            = new AmazonServiceResult<UpdateAuthEventFeedbackRequest,UpdateAuthEventFeedbackResponse>((UpdateAuthEventFeedbackRequest)req, (UpdateAuthEventFeedbackResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateDeviceStatus
        internal virtual UpdateDeviceStatusResponse UpdateDeviceStatus(UpdateDeviceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceStatus operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateDeviceStatus">REST API Reference for UpdateDeviceStatus Operation</seealso>
        public virtual void UpdateDeviceStatusAsync(UpdateDeviceStatusRequest request, AmazonServiceCallback<UpdateDeviceStatusRequest, UpdateDeviceStatusResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateDeviceStatusRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateDeviceStatusResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateDeviceStatusRequest,UpdateDeviceStatusResponse> responseObject 
                            = new AmazonServiceResult<UpdateDeviceStatusRequest,UpdateDeviceStatusResponse>((UpdateDeviceStatusRequest)req, (UpdateDeviceStatusResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateGroup
        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual void UpdateGroupAsync(UpdateGroupRequest request, AmazonServiceCallback<UpdateGroupRequest, UpdateGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateGroupRequest,UpdateGroupResponse> responseObject 
                            = new AmazonServiceResult<UpdateGroupRequest,UpdateGroupResponse>((UpdateGroupRequest)req, (UpdateGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateIdentityProvider
        internal virtual UpdateIdentityProviderResponse UpdateIdentityProvider(UpdateIdentityProviderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProvider operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateIdentityProvider">REST API Reference for UpdateIdentityProvider Operation</seealso>
        public virtual void UpdateIdentityProviderAsync(UpdateIdentityProviderRequest request, AmazonServiceCallback<UpdateIdentityProviderRequest, UpdateIdentityProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateIdentityProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateIdentityProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateIdentityProviderRequest,UpdateIdentityProviderResponse> responseObject 
                            = new AmazonServiceResult<UpdateIdentityProviderRequest,UpdateIdentityProviderResponse>((UpdateIdentityProviderRequest)req, (UpdateIdentityProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateResourceServer
        internal virtual UpdateResourceServerResponse UpdateResourceServer(UpdateResourceServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResourceServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceServerResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceServerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceServer operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateResourceServer">REST API Reference for UpdateResourceServer Operation</seealso>
        public virtual void UpdateResourceServerAsync(UpdateResourceServerRequest request, AmazonServiceCallback<UpdateResourceServerRequest, UpdateResourceServerResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateResourceServerRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateResourceServerResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateResourceServerRequest,UpdateResourceServerResponse> responseObject 
                            = new AmazonServiceResult<UpdateResourceServerRequest,UpdateResourceServerResponse>((UpdateResourceServerRequest)req, (UpdateResourceServerResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateUserAttributes
        internal virtual UpdateUserAttributesResponse UpdateUserAttributes(UpdateUserAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateUserAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserAttributes operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserAttributes">REST API Reference for UpdateUserAttributes Operation</seealso>
        public virtual void UpdateUserAttributesAsync(UpdateUserAttributesRequest request, AmazonServiceCallback<UpdateUserAttributesRequest, UpdateUserAttributesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateUserAttributesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateUserAttributesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateUserAttributesRequest,UpdateUserAttributesResponse> responseObject 
                            = new AmazonServiceResult<UpdateUserAttributesRequest,UpdateUserAttributesResponse>((UpdateUserAttributesRequest)req, (UpdateUserAttributesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateUserPool
        internal virtual UpdateUserPoolResponse UpdateUserPool(UpdateUserPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPool operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPool">REST API Reference for UpdateUserPool Operation</seealso>
        public virtual void UpdateUserPoolAsync(UpdateUserPoolRequest request, AmazonServiceCallback<UpdateUserPoolRequest, UpdateUserPoolResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateUserPoolRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateUserPoolResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateUserPoolRequest,UpdateUserPoolResponse> responseObject 
                            = new AmazonServiceResult<UpdateUserPoolRequest,UpdateUserPoolResponse>((UpdateUserPoolRequest)req, (UpdateUserPoolResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateUserPoolClient
        internal virtual UpdateUserPoolClientResponse UpdateUserPoolClient(UpdateUserPoolClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolClientResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolClient operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolClient">REST API Reference for UpdateUserPoolClient Operation</seealso>
        public virtual void UpdateUserPoolClientAsync(UpdateUserPoolClientRequest request, AmazonServiceCallback<UpdateUserPoolClientRequest, UpdateUserPoolClientResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateUserPoolClientRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateUserPoolClientResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateUserPoolClientRequest,UpdateUserPoolClientResponse> responseObject 
                            = new AmazonServiceResult<UpdateUserPoolClientRequest,UpdateUserPoolClientResponse>((UpdateUserPoolClientRequest)req, (UpdateUserPoolClientResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateUserPoolDomain
        internal virtual UpdateUserPoolDomainResponse UpdateUserPoolDomain(UpdateUserPoolDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserPoolDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserPoolDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateUserPoolDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserPoolDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserPoolDomain operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/UpdateUserPoolDomain">REST API Reference for UpdateUserPoolDomain Operation</seealso>
        public virtual void UpdateUserPoolDomainAsync(UpdateUserPoolDomainRequest request, AmazonServiceCallback<UpdateUserPoolDomainRequest, UpdateUserPoolDomainResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateUserPoolDomainRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateUserPoolDomainResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateUserPoolDomainRequest,UpdateUserPoolDomainResponse> responseObject 
                            = new AmazonServiceResult<UpdateUserPoolDomainRequest,UpdateUserPoolDomainResponse>((UpdateUserPoolDomainRequest)req, (UpdateUserPoolDomainResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  VerifySoftwareToken
        internal virtual VerifySoftwareTokenResponse VerifySoftwareToken(VerifySoftwareTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifySoftwareTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifySoftwareTokenResponseUnmarshaller.Instance;

            return Invoke<VerifySoftwareTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifySoftwareToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifySoftwareToken operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifySoftwareToken">REST API Reference for VerifySoftwareToken Operation</seealso>
        public virtual void VerifySoftwareTokenAsync(VerifySoftwareTokenRequest request, AmazonServiceCallback<VerifySoftwareTokenRequest, VerifySoftwareTokenResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = VerifySoftwareTokenRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = VerifySoftwareTokenResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<VerifySoftwareTokenRequest,VerifySoftwareTokenResponse> responseObject 
                            = new AmazonServiceResult<VerifySoftwareTokenRequest,VerifySoftwareTokenResponse>((VerifySoftwareTokenRequest)req, (VerifySoftwareTokenResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  VerifyUserAttribute
        internal virtual VerifyUserAttributeResponse VerifyUserAttribute(VerifyUserAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyUserAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;

            return Invoke<VerifyUserAttributeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyUserAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyUserAttribute operation on AmazonCognitoIdentityProviderClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-idp-2016-04-18/VerifyUserAttribute">REST API Reference for VerifyUserAttribute Operation</seealso>
        public virtual void VerifyUserAttributeAsync(VerifyUserAttributeRequest request, AmazonServiceCallback<VerifyUserAttributeRequest, VerifyUserAttributeResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = VerifyUserAttributeRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = VerifyUserAttributeResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<VerifyUserAttributeRequest,VerifyUserAttributeResponse> responseObject 
                            = new AmazonServiceResult<VerifyUserAttributeRequest,VerifyUserAttributeResponse>((VerifyUserAttributeRequest)req, (VerifyUserAttributeResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
    }
}