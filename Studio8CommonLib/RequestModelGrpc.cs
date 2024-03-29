﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RequestModel.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class CalcService
{
    static readonly string __ServiceName = "CalcService";

    static readonly grpc::Marshaller<global::CalcRequest> __Marshaller_CalcRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CalcRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CalcResult> __Marshaller_CalcResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CalcResult.Parser.ParseFrom);

    static readonly grpc::Method<global::CalcRequest, global::CalcResult> __Method_Calc = new grpc::Method<global::CalcRequest, global::CalcResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Calc",
        __Marshaller_CalcRequest,
        __Marshaller_CalcResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
        get { return global::RequestModelReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CalcService</summary>
    [grpc::BindServiceMethod(typeof(CalcService), "BindService")]
    public abstract partial class CalcServiceBase
    {
        public virtual global::System.Threading.Tasks.Task<global::CalcResult> Calc(global::CalcRequest request, grpc::ServerCallContext context)
        {
            throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
        }

    }

    /// <summary>Client for CalcService</summary>
    public partial class CalcServiceClient : grpc::ClientBase<CalcServiceClient>
    {
        /// <summary>Creates a new client for CalcService</summary>
        /// <param name="channel">The channel to use to make remote calls.</param>
        public CalcServiceClient(grpc::ChannelBase channel) : base(channel)
        {
        }
        /// <summary>Creates a new client for CalcService that uses a custom <c>CallInvoker</c>.</summary>
        /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
        public CalcServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
        {
        }
        /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
        protected CalcServiceClient() : base()
        {
        }
        /// <summary>Protected constructor to allow creation of configured clients.</summary>
        /// <param name="configuration">The client configuration.</param>
        protected CalcServiceClient(ClientBaseConfiguration configuration) : base(configuration)
        {
        }

        public virtual global::CalcResult Calc(global::CalcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            return Calc(request, new grpc::CallOptions(headers, deadline, cancellationToken));
        }
        public virtual global::CalcResult Calc(global::CalcRequest request, grpc::CallOptions options)
        {
            return CallInvoker.BlockingUnaryCall(__Method_Calc, null, options, request);
        }
        public virtual grpc::AsyncUnaryCall<global::CalcResult> CalcAsync(global::CalcRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            return CalcAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
        }
        public virtual grpc::AsyncUnaryCall<global::CalcResult> CalcAsync(global::CalcRequest request, grpc::CallOptions options)
        {
            return CallInvoker.AsyncUnaryCall(__Method_Calc, null, options, request);
        }
        /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
        protected override CalcServiceClient NewInstance(ClientBaseConfiguration configuration)
        {
            return new CalcServiceClient(configuration);
        }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CalcServiceBase serviceImpl)
    {
        return grpc::ServerServiceDefinition.CreateBuilder()
            .AddMethod(__Method_Calc, serviceImpl.Calc).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalcServiceBase serviceImpl)
    {
        serviceBinder.AddMethod(__Method_Calc, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CalcRequest, global::CalcResult>(serviceImpl.Calc));
    }

}
#endregion
