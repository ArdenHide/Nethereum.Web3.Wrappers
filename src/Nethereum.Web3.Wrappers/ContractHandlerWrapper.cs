using Nethereum.Contracts;
using Nethereum.ABI.Decoders;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.Services;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Nethereum.Web3.Wrappers;

public class ContractHandlerWrapper
{
    private readonly ContractHandler contractHandler;
    public virtual string ContractAddress => contractHandler.ContractAddress;
    public virtual EthApiContractService EthApiContractService => contractHandler.EthApiContractService;

    public ContractHandlerWrapper(ContractHandler contractHandler)
    {
        this.contractHandler = contractHandler;
    }

    public virtual Event<TEventType> GetEvent<TEventType>()
        where TEventType : IEventDTO, new()
    {
        return contractHandler.GetEvent<TEventType>();
    }

    public virtual Function<TEthereumContractFunctionMessage> GetFunction<TEthereumContractFunctionMessage>()
        where TEthereumContractFunctionMessage : new()
    {
        return contractHandler.GetFunction<TEthereumContractFunctionMessage>();
    }

    public virtual Task<TransactionReceipt> SendRequestAndWaitForReceiptAsync<TEthereumContractFunctionMessage>(
        TEthereumContractFunctionMessage? transactionMessage = null, CancellationTokenSource? tokenSource = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
    {
        return contractHandler.SendRequestAndWaitForReceiptAsync(transactionMessage, tokenSource);
    }

    public virtual Task<TransactionReceipt> SendRequestAndWaitForReceiptAsync<TEthereumContractFunctionMessage>(
        TEthereumContractFunctionMessage transactionMessage, CancellationToken cancellationToken)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
    {
        return contractHandler.SendRequestAndWaitForReceiptAsync(transactionMessage, cancellationToken);
    }

    public virtual Task<string> SendRequestAsync<TEthereumContractFunctionMessage>(
        TEthereumContractFunctionMessage? transactionMessage = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
    {
        return contractHandler.SendRequestAsync(transactionMessage);
    }

    public virtual Task<string> SignTransactionAsync<TEthereumContractFunctionMessage>(
        TEthereumContractFunctionMessage? transactionMessage = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
    {
        return contractHandler.SignTransactionAsync(transactionMessage);
    }

    public virtual Task<HexBigInteger> EstimateGasAsync<TEthereumContractFunctionMessage>(
        TEthereumContractFunctionMessage? transactionMessage = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
    {
        return contractHandler.EstimateGasAsync(transactionMessage);
    }

    public virtual Task<TEthereumFunctionReturn> QueryDeserializingToObjectAsync<TEthereumContractFunctionMessage, TEthereumFunctionReturn>(
        TEthereumContractFunctionMessage? ethereumContractFunctionMessage = null, BlockParameter? blockParameter = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
        where TEthereumFunctionReturn : IFunctionOutputDTO, new()
    {
        return contractHandler.QueryDeserializingToObjectAsync<TEthereumContractFunctionMessage, TEthereumFunctionReturn>(ethereumContractFunctionMessage, blockParameter);
    }

    public virtual Task<TReturn> QueryAsync<TEthereumContractFunctionMessage, TReturn>(
        TEthereumContractFunctionMessage? ethereumContractFunctionMessage = null, BlockParameter? blockParameter = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
    {
        return contractHandler.QueryAsync<TEthereumContractFunctionMessage, TReturn>(ethereumContractFunctionMessage, blockParameter);
    }

    public virtual Task<byte[]> QueryRawAsync<TEthereumContractFunctionMessage>(
        TEthereumContractFunctionMessage? ethereumContractFunctionMessage = null, BlockParameter? blockParameter = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
    {
        return contractHandler.QueryRawAsync(ethereumContractFunctionMessage, blockParameter);
    }

    public virtual Task<TReturn> QueryRawAsync<TEthereumContractFunctionMessage, TCustomDecoder, TReturn>(BlockParameter? blockParameter = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
        where TCustomDecoder : ICustomRawDecoder<TReturn>, new()
    {
        return contractHandler.QueryRawAsync<TEthereumContractFunctionMessage, TCustomDecoder, TReturn>(blockParameter);
    }

    public virtual Task<TReturn> QueryRawAsync<TEthereumContractFunctionMessage, TCustomDecoder, TReturn>(
        TEthereumContractFunctionMessage ethereumContractFunctionMessage, BlockParameter? blockParameter = null)
        where TEthereumContractFunctionMessage : FunctionMessage, new()
        where TCustomDecoder : ICustomRawDecoder<TReturn>, new()
    {
        return contractHandler.QueryRawAsync<TEthereumContractFunctionMessage, TCustomDecoder, TReturn>(ethereumContractFunctionMessage, blockParameter);
    }
}