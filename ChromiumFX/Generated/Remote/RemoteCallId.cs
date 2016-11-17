// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {
    internal enum RemoteCallId : ushort {
        CfrMarshalAllocHGlobalRemoteCall,
        CfrMarshalCopyToManagedRemoteCall,
        CfrMarshalCopyToNativeRemoteCall,
        CfrMarshalFreeHGlobalRemoteCall,
        CfxAppCtorRemoteCall,
        CfxBinaryValueCopyRemoteCall,
        CfxBinaryValueCreateFromArrayRemoteCall,
        CfxBinaryValueCreateRemoteCall,
        CfxBinaryValueGetDataRemoteCall,
        CfxBinaryValueGetSizeRemoteCall,
        CfxBinaryValueIsEqualRemoteCall,
        CfxBinaryValueIsOwnedRemoteCall,
        CfxBinaryValueIsSameRemoteCall,
        CfxBinaryValueIsValidRemoteCall,
        CfxBrowserCanGoBackRemoteCall,
        CfxBrowserCanGoForwardRemoteCall,
        CfxBrowserGetFocusedFrameRemoteCall,
        CfxBrowserGetFrameByIdentifierRemoteCall,
        CfxBrowserGetFrameCountRemoteCall,
        CfxBrowserGetFrameIdentifiersRemoteCall,
        CfxBrowserGetFrameNamesRemoteCall,
        CfxBrowserGetFrameRemoteCall,
        CfxBrowserGetIdentifierRemoteCall,
        CfxBrowserGetMainFrameRemoteCall,
        CfxBrowserGoBackRemoteCall,
        CfxBrowserGoForwardRemoteCall,
        CfxBrowserHasDocumentRemoteCall,
        CfxBrowserIsLoadingRemoteCall,
        CfxBrowserIsPopupRemoteCall,
        CfxBrowserIsSameRemoteCall,
        CfxBrowserReloadIgnoreCacheRemoteCall,
        CfxBrowserReloadRemoteCall,
        CfxBrowserSendProcessMessageRemoteCall,
        CfxBrowserStopLoadRemoteCall,
        CfxCommandLineAppendArgumentRemoteCall,
        CfxCommandLineAppendSwitchRemoteCall,
        CfxCommandLineAppendSwitchWithValueRemoteCall,
        CfxCommandLineCopyRemoteCall,
        CfxCommandLineCreateRemoteCall,
        CfxCommandLineGetArgumentsRemoteCall,
        CfxCommandLineGetArgvRemoteCall,
        CfxCommandLineGetCommandLineStringRemoteCall,
        CfxCommandLineGetGlobalRemoteCall,
        CfxCommandLineGetProgramRemoteCall,
        CfxCommandLineGetSwitchesRemoteCall,
        CfxCommandLineGetSwitchValueRemoteCall,
        CfxCommandLineHasArgumentsRemoteCall,
        CfxCommandLineHasSwitchesRemoteCall,
        CfxCommandLineHasSwitchRemoteCall,
        CfxCommandLineInitFromArgvRemoteCall,
        CfxCommandLineInitFromStringRemoteCall,
        CfxCommandLineIsReadOnlyRemoteCall,
        CfxCommandLineIsValidRemoteCall,
        CfxCommandLinePrependWrapperRemoteCall,
        CfxCommandLineResetRemoteCall,
        CfxCommandLineSetProgramRemoteCall,
        CfxDictionaryValueClearRemoteCall,
        CfxDictionaryValueCopyRemoteCall,
        CfxDictionaryValueCreateRemoteCall,
        CfxDictionaryValueGetBinaryRemoteCall,
        CfxDictionaryValueGetBoolRemoteCall,
        CfxDictionaryValueGetDictionaryRemoteCall,
        CfxDictionaryValueGetDoubleRemoteCall,
        CfxDictionaryValueGetIntRemoteCall,
        CfxDictionaryValueGetKeysRemoteCall,
        CfxDictionaryValueGetListRemoteCall,
        CfxDictionaryValueGetSizeRemoteCall,
        CfxDictionaryValueGetStringRemoteCall,
        CfxDictionaryValueGetTypeRemoteCall,
        CfxDictionaryValueGetValueRemoteCall,
        CfxDictionaryValueHasKeyRemoteCall,
        CfxDictionaryValueIsEqualRemoteCall,
        CfxDictionaryValueIsOwnedRemoteCall,
        CfxDictionaryValueIsReadOnlyRemoteCall,
        CfxDictionaryValueIsSameRemoteCall,
        CfxDictionaryValueIsValidRemoteCall,
        CfxDictionaryValueRemoveRemoteCall,
        CfxDictionaryValueSetBinaryRemoteCall,
        CfxDictionaryValueSetBoolRemoteCall,
        CfxDictionaryValueSetDictionaryRemoteCall,
        CfxDictionaryValueSetDoubleRemoteCall,
        CfxDictionaryValueSetIntRemoteCall,
        CfxDictionaryValueSetListRemoteCall,
        CfxDictionaryValueSetNullRemoteCall,
        CfxDictionaryValueSetStringRemoteCall,
        CfxDictionaryValueSetValueRemoteCall,
        CfxDomDocumentGetBaseUrlRemoteCall,
        CfxDomDocumentGetBodyRemoteCall,
        CfxDomDocumentGetCompleteUrlRemoteCall,
        CfxDomDocumentGetDocumentRemoteCall,
        CfxDomDocumentGetElementByIdRemoteCall,
        CfxDomDocumentGetFocusedNodeRemoteCall,
        CfxDomDocumentGetHeadRemoteCall,
        CfxDomDocumentGetSelectionAsMarkupRemoteCall,
        CfxDomDocumentGetSelectionAsTextRemoteCall,
        CfxDomDocumentGetSelectionEndOffsetRemoteCall,
        CfxDomDocumentGetSelectionStartOffsetRemoteCall,
        CfxDomDocumentGetTitleRemoteCall,
        CfxDomDocumentGetTypeRemoteCall,
        CfxDomDocumentHasSelectionRemoteCall,
        CfxDomNodeGetAsMarkupRemoteCall,
        CfxDomNodeGetDocumentRemoteCall,
        CfxDomNodeGetElementAttributeRemoteCall,
        CfxDomNodeGetElementAttributesRemoteCall,
        CfxDomNodeGetElementBoundsRemoteCall,
        CfxDomNodeGetElementInnerTextRemoteCall,
        CfxDomNodeGetElementTagNameRemoteCall,
        CfxDomNodeGetFirstChildRemoteCall,
        CfxDomNodeGetFormControlElementTypeRemoteCall,
        CfxDomNodeGetLastChildRemoteCall,
        CfxDomNodeGetNameRemoteCall,
        CfxDomNodeGetNextSiblingRemoteCall,
        CfxDomNodeGetParentRemoteCall,
        CfxDomNodeGetPreviousSiblingRemoteCall,
        CfxDomNodeGetTypeRemoteCall,
        CfxDomNodeGetValueRemoteCall,
        CfxDomNodeHasChildrenRemoteCall,
        CfxDomNodeHasElementAttributeRemoteCall,
        CfxDomNodeHasElementAttributesRemoteCall,
        CfxDomNodeIsEditableRemoteCall,
        CfxDomNodeIsElementRemoteCall,
        CfxDomNodeIsFormControlElementRemoteCall,
        CfxDomNodeIsSameRemoteCall,
        CfxDomNodeIsTextRemoteCall,
        CfxDomNodeSetElementAttributeRemoteCall,
        CfxDomNodeSetValueRemoteCall,
        CfxDomVisitorCtorRemoteCall,
        CfxDomVisitorVisitActivateRemoteCall,
        CfxDomVisitorVisitDeactivateRemoteCall,
        CfxDomVisitorVisitGetDocumentRemoteCall,
        CfxDomVisitorVisitRemoteClientCall,
        CfxFrameCopyRemoteCall,
        CfxFrameCutRemoteCall,
        CfxFrameDelRemoteCall,
        CfxFrameExecuteJavaScriptRemoteCall,
        CfxFrameGetBrowserRemoteCall,
        CfxFrameGetIdentifierRemoteCall,
        CfxFrameGetNameRemoteCall,
        CfxFrameGetParentRemoteCall,
        CfxFrameGetSourceRemoteCall,
        CfxFrameGetTextRemoteCall,
        CfxFrameGetUrlRemoteCall,
        CfxFrameGetV8ContextRemoteCall,
        CfxFrameIsFocusedRemoteCall,
        CfxFrameIsMainRemoteCall,
        CfxFrameIsValidRemoteCall,
        CfxFrameLoadRequestRemoteCall,
        CfxFrameLoadStringRemoteCall,
        CfxFrameLoadUrlRemoteCall,
        CfxFramePasteRemoteCall,
        CfxFrameRedoRemoteCall,
        CfxFrameSelectAllRemoteCall,
        CfxFrameUndoRemoteCall,
        CfxFrameVisitDomRemoteCall,
        CfxGetByIndexActivateRemoteCall,
        CfxGetByIndexDeactivateRemoteCall,
        CfxGetByIndexGetExceptionRemoteCall,
        CfxGetByIndexGetIndexRemoteCall,
        CfxGetByIndexGetObjectRemoteCall,
        CfxGetByIndexRemoteClientCall,
        CfxGetByIndexSetExceptionRemoteCall,
        CfxGetByIndexSetReturnValueRemoteCall,
        CfxGetByIndexSetRetvalRemoteCall,
        CfxGetByNameActivateRemoteCall,
        CfxGetByNameDeactivateRemoteCall,
        CfxGetByNameGetExceptionRemoteCall,
        CfxGetByNameGetNameRemoteCall,
        CfxGetByNameGetObjectRemoteCall,
        CfxGetByNameRemoteClientCall,
        CfxGetByNameSetExceptionRemoteCall,
        CfxGetByNameSetReturnValueRemoteCall,
        CfxGetByNameSetRetvalRemoteCall,
        CfxGetDataResourceActivateRemoteCall,
        CfxGetDataResourceDeactivateRemoteCall,
        CfxGetDataResourceForScaleActivateRemoteCall,
        CfxGetDataResourceForScaleDeactivateRemoteCall,
        CfxGetDataResourceForScaleGetResourceIdRemoteCall,
        CfxGetDataResourceForScaleGetScaleFactorRemoteCall,
        CfxGetDataResourceForScaleRemoteClientCall,
        CfxGetDataResourceForScaleSetDataRemoteCall,
        CfxGetDataResourceForScaleSetDataSizeRemoteCall,
        CfxGetDataResourceForScaleSetReturnValueRemoteCall,
        CfxGetDataResourceGetResourceIdRemoteCall,
        CfxGetDataResourceRemoteClientCall,
        CfxGetDataResourceSetDataRemoteCall,
        CfxGetDataResourceSetDataSizeRemoteCall,
        CfxGetDataResourceSetReturnValueRemoteCall,
        CfxGetLoadHandlerActivateRemoteCall,
        CfxGetLoadHandlerDeactivateRemoteCall,
        CfxGetLoadHandlerRemoteClientCall,
        CfxGetLoadHandlerSetReturnValueRemoteCall,
        CfxGetLocalizedStringActivateRemoteCall,
        CfxGetLocalizedStringDeactivateRemoteCall,
        CfxGetLocalizedStringGetStringIdRemoteCall,
        CfxGetLocalizedStringGetStringRemoteCall,
        CfxGetLocalizedStringRemoteClientCall,
        CfxGetLocalizedStringSetReturnValueRemoteCall,
        CfxGetLocalizedStringSetStringRemoteCall,
        CfxGetRenderProcessHandlerActivateRemoteCall,
        CfxGetRenderProcessHandlerDeactivateRemoteCall,
        CfxGetRenderProcessHandlerRemoteClientCall,
        CfxGetRenderProcessHandlerSetReturnValueRemoteCall,
        CfxGetResourceBundleHandlerActivateRemoteCall,
        CfxGetResourceBundleHandlerDeactivateRemoteCall,
        CfxGetResourceBundleHandlerRemoteClientCall,
        CfxGetResourceBundleHandlerSetReturnValueRemoteCall,
        CfxListValueClearRemoteCall,
        CfxListValueCopyRemoteCall,
        CfxListValueCreateRemoteCall,
        CfxListValueGetBinaryRemoteCall,
        CfxListValueGetBoolRemoteCall,
        CfxListValueGetDictionaryRemoteCall,
        CfxListValueGetDoubleRemoteCall,
        CfxListValueGetIntRemoteCall,
        CfxListValueGetListRemoteCall,
        CfxListValueGetSizeRemoteCall,
        CfxListValueGetStringRemoteCall,
        CfxListValueGetTypeRemoteCall,
        CfxListValueGetValueRemoteCall,
        CfxListValueIsEqualRemoteCall,
        CfxListValueIsOwnedRemoteCall,
        CfxListValueIsReadOnlyRemoteCall,
        CfxListValueIsSameRemoteCall,
        CfxListValueIsValidRemoteCall,
        CfxListValueRemoveRemoteCall,
        CfxListValueSetBinaryRemoteCall,
        CfxListValueSetBoolRemoteCall,
        CfxListValueSetDictionaryRemoteCall,
        CfxListValueSetDoubleRemoteCall,
        CfxListValueSetIntRemoteCall,
        CfxListValueSetListRemoteCall,
        CfxListValueSetNullRemoteCall,
        CfxListValueSetSizeRemoteCall,
        CfxListValueSetStringRemoteCall,
        CfxListValueSetValueRemoteCall,
        CfxLoadHandlerCtorRemoteCall,
        CfxOnBeforeCommandLineProcessingActivateRemoteCall,
        CfxOnBeforeCommandLineProcessingDeactivateRemoteCall,
        CfxOnBeforeCommandLineProcessingGetCommandLineRemoteCall,
        CfxOnBeforeCommandLineProcessingGetProcessTypeRemoteCall,
        CfxOnBeforeCommandLineProcessingRemoteClientCall,
        CfxOnBeforeNavigationActivateRemoteCall,
        CfxOnBeforeNavigationDeactivateRemoteCall,
        CfxOnBeforeNavigationGetBrowserRemoteCall,
        CfxOnBeforeNavigationGetFrameRemoteCall,
        CfxOnBeforeNavigationGetIsRedirectRemoteCall,
        CfxOnBeforeNavigationGetNavigationTypeRemoteCall,
        CfxOnBeforeNavigationGetRequestRemoteCall,
        CfxOnBeforeNavigationRemoteClientCall,
        CfxOnBeforeNavigationSetReturnValueRemoteCall,
        CfxOnBrowserCreatedActivateRemoteCall,
        CfxOnBrowserCreatedDeactivateRemoteCall,
        CfxOnBrowserCreatedGetBrowserRemoteCall,
        CfxOnBrowserCreatedRemoteClientCall,
        CfxOnBrowserDestroyedActivateRemoteCall,
        CfxOnBrowserDestroyedDeactivateRemoteCall,
        CfxOnBrowserDestroyedGetBrowserRemoteCall,
        CfxOnBrowserDestroyedRemoteClientCall,
        CfxOnContextCreatedActivateRemoteCall,
        CfxOnContextCreatedDeactivateRemoteCall,
        CfxOnContextCreatedGetBrowserRemoteCall,
        CfxOnContextCreatedGetContextRemoteCall,
        CfxOnContextCreatedGetFrameRemoteCall,
        CfxOnContextCreatedRemoteClientCall,
        CfxOnContextReleasedActivateRemoteCall,
        CfxOnContextReleasedDeactivateRemoteCall,
        CfxOnContextReleasedGetBrowserRemoteCall,
        CfxOnContextReleasedGetContextRemoteCall,
        CfxOnContextReleasedGetFrameRemoteCall,
        CfxOnContextReleasedRemoteClientCall,
        CfxOnFocusedNodeChangedActivateRemoteCall,
        CfxOnFocusedNodeChangedDeactivateRemoteCall,
        CfxOnFocusedNodeChangedGetBrowserRemoteCall,
        CfxOnFocusedNodeChangedGetFrameRemoteCall,
        CfxOnFocusedNodeChangedGetNodeRemoteCall,
        CfxOnFocusedNodeChangedRemoteClientCall,
        CfxOnLoadEndActivateRemoteCall,
        CfxOnLoadEndDeactivateRemoteCall,
        CfxOnLoadEndGetBrowserRemoteCall,
        CfxOnLoadEndGetFrameRemoteCall,
        CfxOnLoadEndGetHttpStatusCodeRemoteCall,
        CfxOnLoadEndRemoteClientCall,
        CfxOnLoadErrorActivateRemoteCall,
        CfxOnLoadErrorDeactivateRemoteCall,
        CfxOnLoadErrorGetBrowserRemoteCall,
        CfxOnLoadErrorGetErrorCodeRemoteCall,
        CfxOnLoadErrorGetErrorTextRemoteCall,
        CfxOnLoadErrorGetFailedUrlRemoteCall,
        CfxOnLoadErrorGetFrameRemoteCall,
        CfxOnLoadErrorRemoteClientCall,
        CfxOnLoadingStateChangeActivateRemoteCall,
        CfxOnLoadingStateChangeDeactivateRemoteCall,
        CfxOnLoadingStateChangeGetBrowserRemoteCall,
        CfxOnLoadingStateChangeGetCanGoBackRemoteCall,
        CfxOnLoadingStateChangeGetCanGoForwardRemoteCall,
        CfxOnLoadingStateChangeGetIsLoadingRemoteCall,
        CfxOnLoadingStateChangeRemoteClientCall,
        CfxOnLoadStartActivateRemoteCall,
        CfxOnLoadStartDeactivateRemoteCall,
        CfxOnLoadStartGetBrowserRemoteCall,
        CfxOnLoadStartGetFrameRemoteCall,
        CfxOnLoadStartGetTransitionTypeRemoteCall,
        CfxOnLoadStartRemoteClientCall,
        CfxOnProcessMessageReceivedActivateRemoteCall,
        CfxOnProcessMessageReceivedDeactivateRemoteCall,
        CfxOnProcessMessageReceivedGetBrowserRemoteCall,
        CfxOnProcessMessageReceivedGetMessageRemoteCall,
        CfxOnProcessMessageReceivedGetSourceProcessRemoteCall,
        CfxOnProcessMessageReceivedRemoteClientCall,
        CfxOnProcessMessageReceivedSetReturnValueRemoteCall,
        CfxOnRegisterCustomSchemesActivateRemoteCall,
        CfxOnRegisterCustomSchemesDeactivateRemoteCall,
        CfxOnRegisterCustomSchemesGetRegistrarRemoteCall,
        CfxOnRegisterCustomSchemesRemoteClientCall,
        CfxOnRenderThreadCreatedActivateRemoteCall,
        CfxOnRenderThreadCreatedDeactivateRemoteCall,
        CfxOnRenderThreadCreatedGetExtraInfoRemoteCall,
        CfxOnRenderThreadCreatedRemoteClientCall,
        CfxOnUncaughtExceptionActivateRemoteCall,
        CfxOnUncaughtExceptionDeactivateRemoteCall,
        CfxOnUncaughtExceptionGetBrowserRemoteCall,
        CfxOnUncaughtExceptionGetContextRemoteCall,
        CfxOnUncaughtExceptionGetExceptionRemoteCall,
        CfxOnUncaughtExceptionGetFrameRemoteCall,
        CfxOnUncaughtExceptionGetStackTraceRemoteCall,
        CfxOnUncaughtExceptionRemoteClientCall,
        CfxOnWebKitInitializedActivateRemoteCall,
        CfxOnWebKitInitializedDeactivateRemoteCall,
        CfxOnWebKitInitializedRemoteClientCall,
        CfxPostDataAddElementRemoteCall,
        CfxPostDataCreateRemoteCall,
        CfxPostDataElementCreateRemoteCall,
        CfxPostDataElementGetBytesCountRemoteCall,
        CfxPostDataElementGetBytesRemoteCall,
        CfxPostDataElementGetFileRemoteCall,
        CfxPostDataElementGetTypeRemoteCall,
        CfxPostDataElementIsReadOnlyRemoteCall,
        CfxPostDataElementSetToBytesRemoteCall,
        CfxPostDataElementSetToEmptyRemoteCall,
        CfxPostDataElementSetToFileRemoteCall,
        CfxPostDataGetElementCountRemoteCall,
        CfxPostDataGetElementsRemoteCall,
        CfxPostDataHasExcludedElementsRemoteCall,
        CfxPostDataIsReadOnlyRemoteCall,
        CfxPostDataRemoveElementRemoteCall,
        CfxPostDataRemoveElementsRemoteCall,
        CfxProcessMessageCopyRemoteCall,
        CfxProcessMessageCreateRemoteCall,
        CfxProcessMessageGetArgumentListRemoteCall,
        CfxProcessMessageGetNameRemoteCall,
        CfxProcessMessageIsReadOnlyRemoteCall,
        CfxProcessMessageIsValidRemoteCall,
        CfxRectCtorRemoteCall,
        CfxRectGetHeightRemoteCall,
        CfxRectGetWidthRemoteCall,
        CfxRectGetXRemoteCall,
        CfxRectGetYRemoteCall,
        CfxRectSetHeightRemoteCall,
        CfxRectSetWidthRemoteCall,
        CfxRectSetXRemoteCall,
        CfxRectSetYRemoteCall,
        CfxRenderProcessHandlerCtorRemoteCall,
        CfxRequestCreateRemoteCall,
        CfxRequestGetFirstPartyForCookiesRemoteCall,
        CfxRequestGetFlagsRemoteCall,
        CfxRequestGetHeaderMapRemoteCall,
        CfxRequestGetIdentifierRemoteCall,
        CfxRequestGetMethodRemoteCall,
        CfxRequestGetPostDataRemoteCall,
        CfxRequestGetReferrerPolicyRemoteCall,
        CfxRequestGetReferrerUrlRemoteCall,
        CfxRequestGetResourceTypeRemoteCall,
        CfxRequestGetTransitionTypeRemoteCall,
        CfxRequestGetUrlRemoteCall,
        CfxRequestIsReadOnlyRemoteCall,
        CfxRequestSetFirstPartyForCookiesRemoteCall,
        CfxRequestSetFlagsRemoteCall,
        CfxRequestSetHeaderMapRemoteCall,
        CfxRequestSetMethodRemoteCall,
        CfxRequestSetPostDataRemoteCall,
        CfxRequestSetReferrerRemoteCall,
        CfxRequestSetRemoteCall,
        CfxRequestSetUrlRemoteCall,
        CfxResourceBundleHandlerCtorRemoteCall,
        CfxRuntimeCurrentlyOnRemoteCall,
        CfxRuntimeExecuteProcessRemoteCall,
        CfxRuntimeFormatUrlForSecurityDisplayRemoteCall,
        CfxRuntimeIsCertStatusErrorRemoteCall,
        CfxRuntimeIsCertStatusMinorErrorRemoteCall,
        CfxRuntimePostDelayedTaskRemoteCall,
        CfxRuntimePostTaskRemoteCall,
        CfxRuntimeRegisterExtensionRemoteCall,
        CfxSchemeRegistrarAddCustomSchemeRemoteCall,
        CfxSetByIndexActivateRemoteCall,
        CfxSetByIndexDeactivateRemoteCall,
        CfxSetByIndexGetExceptionRemoteCall,
        CfxSetByIndexGetIndexRemoteCall,
        CfxSetByIndexGetObjectRemoteCall,
        CfxSetByIndexGetValueRemoteCall,
        CfxSetByIndexRemoteClientCall,
        CfxSetByIndexSetExceptionRemoteCall,
        CfxSetByIndexSetReturnValueRemoteCall,
        CfxSetByNameActivateRemoteCall,
        CfxSetByNameDeactivateRemoteCall,
        CfxSetByNameGetExceptionRemoteCall,
        CfxSetByNameGetNameRemoteCall,
        CfxSetByNameGetObjectRemoteCall,
        CfxSetByNameGetValueRemoteCall,
        CfxSetByNameRemoteClientCall,
        CfxSetByNameSetExceptionRemoteCall,
        CfxSetByNameSetReturnValueRemoteCall,
        CfxStringVisitorCtorRemoteCall,
        CfxStringVisitorVisitActivateRemoteCall,
        CfxStringVisitorVisitDeactivateRemoteCall,
        CfxStringVisitorVisitGetStringRemoteCall,
        CfxStringVisitorVisitRemoteClientCall,
        CfxTaskCtorRemoteCall,
        CfxTaskExecuteActivateRemoteCall,
        CfxTaskExecuteDeactivateRemoteCall,
        CfxTaskExecuteRemoteClientCall,
        CfxTaskRunnerBelongsToCurrentThreadRemoteCall,
        CfxTaskRunnerBelongsToThreadRemoteCall,
        CfxTaskRunnerGetForCurrentThreadRemoteCall,
        CfxTaskRunnerGetForThreadRemoteCall,
        CfxTaskRunnerIsSameRemoteCall,
        CfxTaskRunnerPostDelayedTaskRemoteCall,
        CfxTaskRunnerPostTaskRemoteCall,
        CfxTimeCtorRemoteCall,
        CfxTimeGetDayOfMonthRemoteCall,
        CfxTimeGetDayOfWeekRemoteCall,
        CfxTimeGetHourRemoteCall,
        CfxTimeGetMillisecondRemoteCall,
        CfxTimeGetMinuteRemoteCall,
        CfxTimeGetMonthRemoteCall,
        CfxTimeGetSecondRemoteCall,
        CfxTimeGetYearRemoteCall,
        CfxTimeSetDayOfMonthRemoteCall,
        CfxTimeSetDayOfWeekRemoteCall,
        CfxTimeSetHourRemoteCall,
        CfxTimeSetMillisecondRemoteCall,
        CfxTimeSetMinuteRemoteCall,
        CfxTimeSetMonthRemoteCall,
        CfxTimeSetSecondRemoteCall,
        CfxTimeSetYearRemoteCall,
        CfxV8AccessorCtorRemoteCall,
        CfxV8AccessorGetActivateRemoteCall,
        CfxV8AccessorGetDeactivateRemoteCall,
        CfxV8AccessorGetGetExceptionRemoteCall,
        CfxV8AccessorGetGetNameRemoteCall,
        CfxV8AccessorGetGetObjectRemoteCall,
        CfxV8AccessorGetRemoteClientCall,
        CfxV8AccessorGetSetExceptionRemoteCall,
        CfxV8AccessorGetSetReturnValueRemoteCall,
        CfxV8AccessorGetSetRetvalRemoteCall,
        CfxV8AccessorSetActivateRemoteCall,
        CfxV8AccessorSetDeactivateRemoteCall,
        CfxV8AccessorSetGetExceptionRemoteCall,
        CfxV8AccessorSetGetNameRemoteCall,
        CfxV8AccessorSetGetObjectRemoteCall,
        CfxV8AccessorSetGetValueRemoteCall,
        CfxV8AccessorSetRemoteClientCall,
        CfxV8AccessorSetSetExceptionRemoteCall,
        CfxV8AccessorSetSetReturnValueRemoteCall,
        CfxV8ContextEnterRemoteCall,
        CfxV8ContextEvalRemoteCall,
        CfxV8ContextExitRemoteCall,
        CfxV8ContextGetBrowserRemoteCall,
        CfxV8ContextGetCurrentContextRemoteCall,
        CfxV8ContextGetEnteredContextRemoteCall,
        CfxV8ContextGetFrameRemoteCall,
        CfxV8ContextGetGlobalRemoteCall,
        CfxV8ContextGetTaskRunnerRemoteCall,
        CfxV8ContextInContextRemoteCall,
        CfxV8ContextIsSameRemoteCall,
        CfxV8ContextIsValidRemoteCall,
        CfxV8ExceptionGetEndColumnRemoteCall,
        CfxV8ExceptionGetEndPositionRemoteCall,
        CfxV8ExceptionGetLineNumberRemoteCall,
        CfxV8ExceptionGetMessageRemoteCall,
        CfxV8ExceptionGetScriptResourceNameRemoteCall,
        CfxV8ExceptionGetSourceLineRemoteCall,
        CfxV8ExceptionGetStartColumnRemoteCall,
        CfxV8ExceptionGetStartPositionRemoteCall,
        CfxV8HandlerCtorRemoteCall,
        CfxV8HandlerExecuteActivateRemoteCall,
        CfxV8HandlerExecuteDeactivateRemoteCall,
        CfxV8HandlerExecuteGetArgumentsRemoteCall,
        CfxV8HandlerExecuteGetNameRemoteCall,
        CfxV8HandlerExecuteGetObjectRemoteCall,
        CfxV8HandlerExecuteRemoteClientCall,
        CfxV8HandlerExecuteSetExceptionRemoteCall,
        CfxV8HandlerExecuteSetReturnValueRemoteCall,
        CfxV8InterceptorCtorRemoteCall,
        CfxV8StackFrameGetColumnRemoteCall,
        CfxV8StackFrameGetFunctionNameRemoteCall,
        CfxV8StackFrameGetLineNumberRemoteCall,
        CfxV8StackFrameGetScriptNameOrSourceUrlRemoteCall,
        CfxV8StackFrameGetScriptNameRemoteCall,
        CfxV8StackFrameIsConstructorRemoteCall,
        CfxV8StackFrameIsEvalRemoteCall,
        CfxV8StackFrameIsValidRemoteCall,
        CfxV8StackTraceGetCurrentRemoteCall,
        CfxV8StackTraceGetFrameCountRemoteCall,
        CfxV8StackTraceGetFrameRemoteCall,
        CfxV8StackTraceIsValidRemoteCall,
        CfxV8ValueAdjustExternallyAllocatedMemoryRemoteCall,
        CfxV8ValueClearExceptionRemoteCall,
        CfxV8ValueCreateArrayRemoteCall,
        CfxV8ValueCreateBoolRemoteCall,
        CfxV8ValueCreateDateRemoteCall,
        CfxV8ValueCreateDoubleRemoteCall,
        CfxV8ValueCreateFunctionRemoteCall,
        CfxV8ValueCreateIntRemoteCall,
        CfxV8ValueCreateNullRemoteCall,
        CfxV8ValueCreateObjectRemoteCall,
        CfxV8ValueCreateStringRemoteCall,
        CfxV8ValueCreateUintRemoteCall,
        CfxV8ValueCreateUndefinedRemoteCall,
        CfxV8ValueDeleteValueByIndexRemoteCall,
        CfxV8ValueDeleteValueByKeyRemoteCall,
        CfxV8ValueExecuteFunctionRemoteCall,
        CfxV8ValueExecuteFunctionWithContextRemoteCall,
        CfxV8ValueGetArrayLengthRemoteCall,
        CfxV8ValueGetBoolValueRemoteCall,
        CfxV8ValueGetDateValueRemoteCall,
        CfxV8ValueGetDoubleValueRemoteCall,
        CfxV8ValueGetExceptionRemoteCall,
        CfxV8ValueGetExternallyAllocatedMemoryRemoteCall,
        CfxV8ValueGetFunctionHandlerRemoteCall,
        CfxV8ValueGetFunctionNameRemoteCall,
        CfxV8ValueGetIntValueRemoteCall,
        CfxV8ValueGetKeysRemoteCall,
        CfxV8ValueGetStringValueRemoteCall,
        CfxV8ValueGetUintValueRemoteCall,
        CfxV8ValueGetUserDataRemoteCall,
        CfxV8ValueGetValueByIndexRemoteCall,
        CfxV8ValueGetValueByKeyRemoteCall,
        CfxV8ValueHasExceptionRemoteCall,
        CfxV8ValueHasValueByIndexRemoteCall,
        CfxV8ValueHasValueByKeyRemoteCall,
        CfxV8ValueIsArrayRemoteCall,
        CfxV8ValueIsBoolRemoteCall,
        CfxV8ValueIsDateRemoteCall,
        CfxV8ValueIsDoubleRemoteCall,
        CfxV8ValueIsFunctionRemoteCall,
        CfxV8ValueIsIntRemoteCall,
        CfxV8ValueIsNullRemoteCall,
        CfxV8ValueIsObjectRemoteCall,
        CfxV8ValueIsSameRemoteCall,
        CfxV8ValueIsStringRemoteCall,
        CfxV8ValueIsUintRemoteCall,
        CfxV8ValueIsUndefinedRemoteCall,
        CfxV8ValueIsUserCreatedRemoteCall,
        CfxV8ValueIsValidRemoteCall,
        CfxV8ValueSetRethrowExceptionsRemoteCall,
        CfxV8ValueSetUserDataRemoteCall,
        CfxV8ValueSetValueByAccessorRemoteCall,
        CfxV8ValueSetValueByIndexRemoteCall,
        CfxV8ValueSetValueByKeyRemoteCall,
        CfxV8ValueWillRethrowExceptionsRemoteCall,
        CfxValueCopyRemoteCall,
        CfxValueCreateRemoteCall,
        CfxValueGetBinaryRemoteCall,
        CfxValueGetBoolRemoteCall,
        CfxValueGetDictionaryRemoteCall,
        CfxValueGetDoubleRemoteCall,
        CfxValueGetIntRemoteCall,
        CfxValueGetListRemoteCall,
        CfxValueGetStringRemoteCall,
        CfxValueGetTypeRemoteCall,
        CfxValueIsEqualRemoteCall,
        CfxValueIsOwnedRemoteCall,
        CfxValueIsReadOnlyRemoteCall,
        CfxValueIsSameRemoteCall,
        CfxValueIsValidRemoteCall,
        CfxValueSetBinaryRemoteCall,
        CfxValueSetBoolRemoteCall,
        CfxValueSetDictionaryRemoteCall,
        CfxValueSetDoubleRemoteCall,
        CfxValueSetIntRemoteCall,
        CfxValueSetListRemoteCall,
        CfxValueSetNullRemoteCall,
        CfxValueSetStringRemoteCall,
        ExecuteProcessRemoteCall,
        ReleaseRemotePtrRemoteCall
    }
}
