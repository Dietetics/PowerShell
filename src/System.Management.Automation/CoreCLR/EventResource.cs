// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#if UNIX
/*
    This code was generated by the tools\ResxGen\ResxGen.ps1 run against PowerShell.Core.Instrumentation.man.
    To add or change logged events and the associated resources, edit PowerShell.Core.Instrumentation.man
    then rerun ResxGen.ps1 to produce an updated CS and Resx file.
*/
using System.Collections.Generic;
using System.Management.Automation.Internal;
using System.Runtime.InteropServices;

namespace System.Management.Automation.Tracing
{
    /// <summary>
    /// Provides a class for describing a message resource for an ETW event.
    /// </summary>
    internal static class EventResource
    {
        // Defines the resource id of the message to use when an event id is not valid.
        private const string MissingEventIdResourceName = "MissingEventIdMessage";

        /// <summary>
        /// Gets the name of the message resource to use for event ids that are not found.
        /// is not found.
        /// </summary>
        /// <remarks>
        /// This method is called when GetMessage returns a null value indicating the passed
        /// in event id was not found. The message should be used as the format string
        /// with the event id as the single variable argument.
        /// <remarks>
        public static string GetMissingEventMessage(out int parameterCount)
        {
            parameterCount = 1;
            return MissingEventIdResourceName;
        }

        /// <summary>
        /// Gets the message resource id for the specified event id
        /// </summary>
        /// <param name="eventId">The event id for the message resource to retrieve.</param>
        /// <param name="parameterCount">The number of parameters required by the message resource.</param>
        /// <returns>The string resource id of the associated event message; otherwise, a null reference if the event id is not valid.</returns>
        public static string GetMessage(int eventId, out int parameterCount)
        {
            switch (eventId)
            {
                case 4097:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_CMDLETS_HOSTNAMERESOLVE";
                case 4098:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_CMDLETS_SCHEMERESOLVE";
                case 4099:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_CMDLETS_SHELLRESOLVE";
                case 4100:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_COMMAND_HEALTH";
                case 4101:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_ENGINE_HEALTH";
                case 4102:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_PROVIDER_HEALTH";
                case 4103:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_PIPELINE_DETAIL";
                case 4104:
                    parameterCount = 5;
                    return "PS_PROVIDEReventE_O_SCRIPTBLOCK_CREATE_DETAIL";
                case 4105:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_SCRIPTBLOCK_INVOKE_START_DETAIL";
                case 4106:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_SCRIPTBLOCK_INVOKE_COMPLETE_DETAIL";
                case 7937:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_COMMAND_LIFECYCLE";
                case 7938:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_ENGINE_LIFECYCLE";
                case 7939:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_PROVIDER_LIFECYCLE";
                case 7940:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_SETTINGS";
                case 7941:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_WriteTransferEvent";
                case 7942:
                    parameterCount = 8;
                    return "PS_PROVIDEReventE_A_ENGINE_TRACE";
                case 8193:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_RUNSPACE_CONSTRUCTOR";
                case 8194:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_RUNSPACEPOOL_CONSTRUCTOR";
                case 8195:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_RUNSPACEPOOL_OPEN";
                case 8196:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_RUNSPACEPOOL_TRANSFER";
                case 8197:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_RUNSPACE_STATE_CHANGE";
                case 8198:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_REMOTE_RUNSPACE_CREATE_RETRY";
                case 12033:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_RUNSPACE_PORT";
                case 12034:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_RUNSPACE_APPNAME";
                case 12035:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_RUNSPACE_COMPUTERNAME";
                case 12036:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_RUNSPACE_SCHEME";
                case 12037:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_A_RUNSPACE_TEST";
                case 12038:
                    parameterCount = 9;
                    return "PS_PROVIDEReventE_A_RUNSPACE_WSMANCONNECTIONINFO";
                case 12039:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_A_RUNSPACEPOOL_TRANSFER";
                case 12289:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_ExperimentalFeatureInvalidName";
                case 12290:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_ExperimentalFeatureReadConfigError";
                case 24577:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_ISEExecuteScript";
                case 24578:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_ISEExecuteSelection";
                case 24579:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISEStopCommand";
                case 24580:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISEResumeDebugger";
                case 24581:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISEStopDebugger";
                case 24582:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISEDebuggerStepInto";
                case 24583:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISEDebuggerStepOver";
                case 24584:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISEDebuggerStepOut";
                case 24592:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISEEnableAllBreakpoints";
                case 24593:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISEDisableAllBreakpoints";
                case 24594:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_ISERemoveAllBreakpoints";
                case 24595:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_ISESetBreakpoint";
                case 24596:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_ISERemoveBreakpoint";
                case 24597:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_ISEEnableBreakpoint";
                case 24598:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_ISEDisableBreakpoint";
                case 24599:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_ISEHitBreakpoint";
                case 28673:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_SERIALIZER_REHYDRATION_SUCCESS";
                case 28674:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_A_SERIALIZER_REHYDRATION_FAILURE";
                case 28675:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_A_SERIALIZER_DEPTH_OVERRIDE";
                case 28676:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_SERIALIZER_MODE_OVERRIDE";
                case 28677:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_SERIALIZER_SCRIPT_PROPERTY_WITHOUT_RUNSPACE";
                case 28678:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_A_SERIALIZER_PROPERTY_GETTER_FAILED";
                case 28679:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_SERIALIZER_ENUMERATION_FAILED";
                case 28680:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_SERIALIZER_TOSTRING_FAILED";
                case 28682:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_SERIALIZER_MAX_DEPTH_WHEN_SERIALIZING";
                case 28683:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_SERIALIZER_XMLEXCEPTION_WHEN_DESERIALIZING";
                case 28684:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_SERIALIZER_SPECIFIC_PROPERTY_MISSING";
                case 32769:
                    parameterCount = 5;
                    return "PS_PROVIDEReventE_A_TRANSPORT_RCVDOBJ";
                case 32775:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_APPDOMAIN_UNHANDLED_EXCEPTION";
                case 32776:
                    parameterCount = 5;
                    return "PS_PROVIDEReventE_A_TRANSPORT_ERROR";
                case 32777:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_APPDOMAIN_UNHANDLED_EXCEPTION";
                case 32784:
                    parameterCount = 5;
                    return "PS_PROVIDEReventE_O_TRANSPORT_ERROR";
                case 32785:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_TRANSPORT_CONNECT";
                case 32786:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_TRANSPORT_SHELL_CONNECT_CALLBACK";
                case 32787:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_TRANSPORT_SHELL_CLOSE";
                case 32788:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_TRANSPORT_SHELL_CLOSE_CALLBACK";
                case 32789:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_TRANSPORT_SEND_DATA";
                case 32790:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_TRANSPORT_SEND_DATA_CALLBACK";
                case 32791:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_TRANSPORT_RECEIVE_DATA";
                case 32792:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_TRANSPORT_RECEIVE_DATA_CALLBACK";
                case 32793:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_TRANSPORT_CMD_CONNECT";
                case 32800:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_TRANSPORT_CMD_CONNECT_CALLBACK";
                case 32801:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_TRANSPORT_CMD_CLOSE";
                case 32802:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_TRANSPORT_CMD_CLOSE_CALLBACK";
                case 32803:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_TRANSPORT_SIGNAL";
                case 32804:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_TRANSPORT_SIGNAL_CALLBACK";
                case 32805:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_TRANSPORT_URI_REDIRECTION";
                case 32849:
                    parameterCount = 5;
                    return "PS_PROVIDEReventE_A_TRANSPORT_SERVER_SEND_DATA";
                case 32850:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_CREATE_SERVER_REMOTESESSION";
                case 32851:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_A_REPORT_CONTEXT";
                case 32852:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_A_REPORT_OPERATION_COMPLETE";
                case 32853:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_CREATE_COMMAND_REMOTESESSION";
                case 32854:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_STOP_COMMAND";
                case 32855:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_SERVER_RECEIVED_DATA";
                case 32856:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_SERVER_RECEIVE_REQUEST";
                case 32857:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_A_SERVER_CLOSE_OPERATION";
                case 32865:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_LOAD_PSCUSTOMSHELL_ASSEMBLY";
                case 32866:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_A_LOAD_PSCUSTOMSHELL_TYPE";
                case 32867:
                    parameterCount = 6;
                    return "PS_PROVIDEReventE_A_RECEIVED_FRAGMENT";
                case 32868:
                    parameterCount = 6;
                    return "PS_PROVIDEReventE_A_SENT_FRAGMENT";
                case 32869:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_A_SHUTTING_DOWN";
                case 40961:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_PowershellConsoleStartupStart";
                case 40962:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_PowershellConsoleStartupStop";
                case 45057:
                    parameterCount = 8;
                    return "PS_PROVIDEReventE_D_Powershell_ErrorRecord";
                case 45058:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_D_Powershell_Exception";
                case 45059:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_Powershell_PSObject";
                case 45060:
                    parameterCount = 6;
                    return "PS_PROVIDEReventE_D_Powershell_Job";
                case 45061:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_MESSAGE";
                case 45062:
                    parameterCount = 9;
                    return "PS_PROVIDEReventE_A_RUNSPACE_WSMANCONNECTIONINFO";
                case 45063:
                    parameterCount = 5;
                    return "PS_PROVIDEReventE_O_M3PWorkflowPluginStarted";
                case 45064:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowExecutionStarted";
                case 45065:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PWorkflowStateChanged";
                case 45072:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowPluginRequestedToShutdown";
                case 45073:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowPluginRestarted";
                case 45074:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowWorkflowsResuming";
                case 45075:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_O_M3PWorkflowQuotaViolationDetected";
                case 45076:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowWorkflowsResumed";
                case 45078:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowRunspacePoolCreated";
                case 45079:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowActivityExecutionQueued";
                case 45080:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowActivityExecutionStarted";
                case 45081:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowImportingFromXaml";
                case 45082:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowImportedFromXaml";
                case 45083:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowImportFromXamlError";
                case 45084:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowImportFromXamlValidationStarted";
                case 45085:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowImportFromXamlValidationFinishedSuccessfully";
                case 45086:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowImportFromXamlValidationFinishedWithError";
                case 45087:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PWorkflowImportFromXamlActivityValidated";
                case 45088:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PWorkflowImportFromXamlActivityValidationFailed";
                case 45089:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PWorkflowActivityExecutionFailed";
                case 45090:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowRunspaceAvailabilityChanged";
                case 45091:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PWorkflowRunspaceStateChanged";
                case 45092:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowLoadedForExecution";
                case 45093:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowUnloaded";
                case 45094:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowCancelled";
                case 45095:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowAborted";
                case 45096:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowCleanup";
                case 45097:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowLoadedFromDisk";
                case 45098:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowDeletedFromDisk";
                case 45100:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PRemoveJobStarted";
                case 45101:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_O_M3PJobStateChanged";
                case 45102:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PJobError";
                case 45104:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PWorkflowJobCreated";
                case 45105:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PParentJobCreated";
                case 45106:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PJobCreationCompleted";
                case 45107:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PJobRemoved";
                case 45108:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_O_M3PJobRemoveError";
                case 45109:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PLoadingWorkflowForExecution";
                case 45110:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowExecutionFinished";
                case 45111:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PCancellingWorkflowExecution";
                case 45112:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PAbortingWorkflowExecution";
                case 45113:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PUnloadingWorkflow";
                case 45114:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PForcedWorkflowShutdownStarted";
                case 45115:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PForcedWorkflowShutdownFinished";
                case 45116:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PForcedWorkflowShutdownError";
                case 45117:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PPersistingWorkflow";
                case 45118:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowPersisted";
                case 45119:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowActivityExecutionFinished";
                case 45120:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PWorkflowExecutionError";
                case 45121:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_M3PEndpointRegistered";
                case 45122:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PEndpointModified";
                case 45123:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PEndpointUnregistered";
                case 45124:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PEndpointDisabled";
                case 45125:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PEndpointEnabled";
                case 45126:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3POutOfProcessRunspaceStarted";
                case 45127:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_M3PParameterSplattingWasPerformed";
                case 45128:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_O_M3PWorkflowEngineStarted";
                case 45129:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_D_M3PWORKFLOW_MANAGER_CHECKPOINTPATH";
                case 46337:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PBeginStartWorkflowApplication";
                case 46338:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PEndStartWorkflowApplication";
                case 46339:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PBeginCreateNewJob";
                case 46340:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PEndCreateNewJob";
                case 46341:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_D_M3PTrackingGuidContainerParentJobCorrelation";
                case 46342:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PBeginJobLogic";
                case 46343:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PEndJobLogic";
                case 46344:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PBeginWorkflowExecution";
                case 46345:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PEndWorkflowExecution";
                case 46346:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_D_M3PChildWorkflowJobAddition";
                case 46347:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_D_M3PProxyJobRemoteJobAssociation";
                case 46348:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PBeginContainerParentJobExecution";
                case 46349:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PEndContainerParentJobExecution";
                case 46350:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PBeginProxyJobExecution";
                case 46351:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PEndProxyJobExecution";
                case 46352:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PBeginProxyJobEventHandler";
                case 46353:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PEndProxyJobEventHandler";
                case 46354:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PBeginProxyChildJobEventHandler";
                case 46355:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_M3PEndProxyChildJobEventHandler";
                case 46356:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_D_M3PBeginRunGarbageCollection";
                case 46357:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_D_M3PEndRunGarbageCollection";
                case 46358:
                    parameterCount = 0;
                    return "PS_PROVIDEReventE_O_M3PPERSISTENCE_STORE_MAXSIZE_REACHED";
                case 49152:
                    parameterCount = 1;
                    return "PS_PROVIDEReventE_D_DebugMessage";
                case 49153:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_D_MESSAGE2";
                case 53249:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_ScheduledJobStarted";
                case 53250:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_ScheduledJobCompleted";
                case 53251:
                    parameterCount = 4;
                    return "PS_PROVIDEReventE_O_ScheduledJobException";
                case 53504:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_REMOTE_NAMEDPIPE_LISTENER_START";
                case 53505:
                    parameterCount = 2;
                    return "PS_PROVIDEReventE_O_REMOTE_NAMEDPIPE_LISTENER_END";
                case 53506:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_REMOTE_NAMEDPIPE_LISTENER_ERROR";
                case 53507:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_REMOTE_NAMEDPIPE_CONNECT";
                case 53508:
                    parameterCount = 3;
                    return "PS_PROVIDEReventE_O_REMOTE_NAMEDPIPE_DISCONNECT";
            }

            parameterCount = 0;
            return null;
        }
    }
}
#endif
