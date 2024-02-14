using System.Numerics;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.Standards.ERC20;
using Nethereum.Contracts.Standards.ERC20.ContractDefinition;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts.Services;

namespace Nethereum.Web3.Wrappers;

/// <summary>
/// Provides a wrapper around the <see cref="ERC20ContractService"/> to interact with ERC20 tokens on the Ethereum blockchain.
/// </summary>
/// <remarks>
/// This wrapper simplifies the usage of the ERC20 contract service by abstracting away some of the complexities involved in blockchain transactions.
/// </remarks>
public class ERC20ContractServiceWrapper
{
    protected readonly ERC20ContractService contractService;

    public ERC20ContractServiceWrapper(IWeb3 web3, string contractAddress)
    {
        this.contractService = web3.Eth.ERC20.GetContractService(contractAddress);
    }

    public ERC20ContractServiceWrapper(IEthApiContractService eth, string contractAddress)
    {
        this.contractService = eth.ERC20.GetContractService(contractAddress);
    }

    public ERC20ContractServiceWrapper(ERC20Service erc20, string contractAddress)
    {
        this.contractService = erc20.GetContractService(contractAddress);
    }

    public ERC20ContractServiceWrapper(ERC20ContractService contractService)
    {
        this.contractService = contractService;
    }

    /// <inheritdoc cref="ERC20ContractService.ContractAddress"/>
    public virtual string ContractAddress => contractService.ContractAddress;

    /// <inheritdoc cref="ERC20ContractService.ContractHandler"/>
    public virtual ContractHandler ContractHandler => contractService.ContractHandler;

    /// <inheritdoc cref="ERC20ContractService.TotalSupplyQueryAsync(TotalSupplyFunction, BlockParameter)"/>
    public virtual async Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter? blockParameter = null)
    {
        return await contractService.TotalSupplyQueryAsync(totalSupplyFunction, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.TotalSupplyQueryAsync(BlockParameter)"/>
    public virtual async Task<BigInteger> TotalSupplyQueryAsync(BlockParameter? blockParameter = null)
    {
        return await contractService.TotalSupplyQueryAsync(blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.DecimalsQueryAsync(DecimalsFunction, BlockParameter)"/>
    public virtual async Task<byte> DecimalsQueryAsync(DecimalsFunction decimalsFunction, BlockParameter? blockParameter = null)
    {
        return await contractService.DecimalsQueryAsync(decimalsFunction, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.DecimalsQueryAsync(BlockParameter)"/>
    public virtual async Task<byte> DecimalsQueryAsync(BlockParameter? blockParameter = null)
    {
        return await contractService.DecimalsQueryAsync(blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.NameQueryAsync(NameFunction, BlockParameter)"/>
    public virtual async Task<string> NameQueryAsync(NameFunction? nameFunction = null, BlockParameter? blockParameter = null)
    {
        return await contractService.NameQueryAsync(nameFunction, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.SymbolQueryAsync(SymbolFunction, BlockParameter)"/>
    public virtual async Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter? blockParameter = null)
    {
        return await contractService.SymbolQueryAsync(symbolFunction, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.ApproveRequestAsync(ApproveFunction)"/>
    public virtual async Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
    {
        return await contractService.ApproveRequestAsync(approveFunction);
    }

    /// <inheritdoc cref="ERC20ContractService.ApproveRequestAsync(string, BigInteger)"/>
    public virtual async Task<string> ApproveRequestAsync(string spender, BigInteger value)
    {
        return await contractService.ApproveRequestAsync(spender, value);
    }

    /// <inheritdoc cref="ERC20ContractService.TransferFromRequestAsync(TransferFromFunction)"/>
    public virtual async Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
    {
        return await contractService.TransferFromRequestAsync(transferFromFunction);
    }

    /// <inheritdoc cref="ERC20ContractService.TransferFromRequestAsync(string, string, BigInteger)"/>
    public virtual async Task<string> TransferFromRequestAsync(string from, string to, BigInteger value)
    {
        return await contractService.TransferFromRequestAsync(from, to, value);
    }

    /// <inheritdoc cref="ERC20ContractService.TransferRequestAsync(TransferFunction)"/>
    public virtual async Task<string> TransferFromRequestAsync(TransferFunction transferFunction)
    {
        return await contractService.TransferRequestAsync(transferFunction);
    }

    /// <inheritdoc cref="ERC20ContractService.TransferRequestAsync(string, BigInteger)"/>
    public virtual async Task<string> TransferFromRequestAsync(string to, BigInteger value)
    {
        return await contractService.TransferRequestAsync(to, value);
    }

    /// <inheritdoc cref="ERC20ContractService.AllowanceQueryAsync(AllowanceFunction, BlockParameter)"/>
    public virtual async Task<BigInteger> AllowanceQueryAsync(AllowanceFunction allowanceFunction, BlockParameter? blockParameter = null)
    {
        return await contractService.AllowanceQueryAsync(allowanceFunction, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.AllowanceQueryAsync(string, string, BlockParameter)"/>
    public virtual async Task<BigInteger> AllowanceQueryAsync(string owner, string spender, BlockParameter? blockParameter = null)
    {
        return await contractService.AllowanceQueryAsync(owner, spender, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.AllowedQueryAsync(AllowedFunction, BlockParameter)"/>
    public virtual async Task<BigInteger> AllowedQueryAsync(AllowedFunction allowedFunction, BlockParameter? blockParameter = null)
    {
        return await contractService.AllowedQueryAsync(allowedFunction, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.AllowedQueryAsync(string, string, BlockParameter)"/>
    public virtual async Task<BigInteger> AllowedQueryAsync(string owner, string spender, BlockParameter? blockParameter = null)
    {
        return await contractService.AllowedQueryAsync(owner, spender, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.BalanceOfQueryAsync(BalanceOfFunction, BlockParameter)"/>
    public virtual async Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter? blockParameter = null)
    {
        return await contractService.BalanceOfQueryAsync(balanceOfFunction, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.BalanceOfQueryAsync(string, BlockParameter)"/>
    public virtual async Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter? blockParameter = null)
    {
        return await contractService.BalanceOfQueryAsync(owner, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.BalancesQueryAsync(BalancesFunction, BlockParameter)"/>
    public virtual async Task<BigInteger> BalancesQueryAsync(BalancesFunction balancesFunction, BlockParameter? blockParameter = null)
    {
        return await contractService.BalancesQueryAsync(balancesFunction, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.BalancesQueryAsync(string, BlockParameter)"/>
    public virtual async Task<BigInteger> BalancesQueryAsync(string owner, BlockParameter? blockParameter = null)
    {
        return await contractService.BalancesQueryAsync(owner, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.GetBalanceFromStorageAsync(string, BigInteger, BlockParameter)"/>
    public virtual async Task<BigInteger> GetBalanceFromStorageAsync(string address, BigInteger slot, BlockParameter? blockParameter = null)
    {
        return await contractService.GetBalanceFromStorageAsync(address, slot, blockParameter);
    }

    /// <inheritdoc cref="ERC20ContractService.ApproveRequestAndWaitForReceiptAsync(ApproveFunction, CancellationToken)"/>
    public virtual async Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationToken cancellationToken = default)
    {
        return await contractService.ApproveRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
    }

    /// <inheritdoc cref="ERC20ContractService.ApproveRequestAndWaitForReceiptAsync(string, BigInteger, CancellationToken)"/>
    public virtual async Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string spender, BigInteger value, CancellationToken cancellationToken = default)
    {
        return await contractService.ApproveRequestAndWaitForReceiptAsync(spender, value, cancellationToken);
    }

    /// <inheritdoc cref="ERC20ContractService.TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction, CancellationToken)"/>
    public virtual async Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationToken cancellationToken = default)
    {
        return await contractService.TransferFromRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
    }

    /// <inheritdoc cref="ERC20ContractService.TransferFromRequestAndWaitForReceiptAsync(string, string, BigInteger, CancellationToken)"/>
    public virtual async Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger value, CancellationToken cancellationToken = default)
    {
        return await contractService.TransferFromRequestAndWaitForReceiptAsync(from, to, value, cancellationToken);
    }

    /// <inheritdoc cref="ERC20ContractService.TransferRequestAndWaitForReceiptAsync(TransferFunction, CancellationToken)"/>
    public virtual async Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction, CancellationToken cancellationToken = default)
    {
        return await contractService.TransferRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
    }

    /// <inheritdoc cref="ERC20ContractService.TransferRequestAndWaitForReceiptAsync(string, BigInteger, CancellationToken)"/>
    public virtual async Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(string to, BigInteger value, CancellationToken cancellationToken = default)
    {
        return await contractService.TransferRequestAndWaitForReceiptAsync(to, value, cancellationToken);
    }
}