function callDotNetMethodFromWasm(dotNetHelper, methodName, token) {
    dotNetHelper.invokeMethodAsync(methodName, token);
}