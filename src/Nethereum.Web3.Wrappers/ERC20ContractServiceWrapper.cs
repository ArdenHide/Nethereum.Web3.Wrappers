using System.Numerics;
using Nethereum.Contracts;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.Standards.ERC20;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts.Standards.ERC20.ContractDefinition;

namespace Nethereum.Web3.Wrappers;

public class ERC20ContractServiceWrapper
{
    private readonly ERC20ContractService contractService;

    public virtual string ContractAddress => contractService.ContractAddress;
    public virtual ContractHandler ContractHandler => contractService.ContractHandler;

    public ERC20ContractServiceWrapper(ERC20ContractService contractService)
    {
        this.contractService = contractService;
    }

    public virtual Event<ApprovalEventDTO> GetApprovalEvent()
    {
        return contractService.GetApprovalEvent();
    }

    public virtual Event<TransferEventDTO> GetTransferEvent()
    {
        return contractService.GetTransferEvent();
    }

    public virtual Task<string> NameQueryAsync(NameFunction? nameFunction = null, BlockParameter? blockParameter = null)
    {
        return contractService.NameQueryAsync(nameFunction, blockParameter);
    }

    public virtual Task<string> SymbolQueryAsync(SymbolFunction? symbolFunction = null, BlockParameter? blockParameter = null)
    {
        return contractService.SymbolQueryAsync(symbolFunction, blockParameter);
    }

    public virtual Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
    {
        return contractService.ApproveRequestAsync(approveFunction);
    }

    public virtual Task<string> ApproveRequestAsync(string spender, BigInteger value)
    {
        return contractService.ApproveRequestAsync(spender, value);
    }

    public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationToken cancellationToken = default)
    {
        return contractService.ApproveRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
    }

    public virtual Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string spender, BigInteger value, CancellationToken cancellationToken = default)
    {
        return contractService.ApproveRequestAndWaitForReceiptAsync(spender, value, cancellationToken);
    }

    public virtual Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter? blockParameter = null)
    {
        return contractService.TotalSupplyQueryAsync(totalSupplyFunction, blockParameter);
    }

    public virtual Task<BigInteger> TotalSupplyQueryAsync(BlockParameter? blockParameter = null)
    {
        return contractService.TotalSupplyQueryAsync(blockParameter);
    }

    public virtual Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
    {
        return contractService.TransferFromRequestAsync(transferFromFunction);
    }

    public virtual Task<string> TransferFromRequestAsync(string from, string to, BigInteger value)
    {
        return contractService.TransferFromRequestAsync(from, to, value);
    }

    public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction,
        CancellationToken cancellationToken = default)
    {
        return contractService.TransferFromRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
    }

    public virtual Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger value, CancellationToken cancellationToken = default)
    {
        return contractService.TransferFromRequestAndWaitForReceiptAsync(from, to, value, cancellationToken);
    }

    public virtual Task<BigInteger> GetBalanceFromStorageAsync(string address, BigInteger slot, BlockParameter? blockParameter = null)
    {
        return contractService.GetBalanceFromStorageAsync(address, slot, blockParameter);
    }

    public virtual Task<BigInteger> BalancesQueryAsync(BalancesFunction balancesFunction, BlockParameter? blockParameter = null)
    {
        return contractService.BalancesQueryAsync(balancesFunction, blockParameter);
    }

    public virtual Task<BigInteger> BalancesQueryAsync(string address, BlockParameter? blockParameter = null)
    {
        return contractService.BalancesQueryAsync(address, blockParameter);
    }

    public virtual Task<byte> DecimalsQueryAsync(DecimalsFunction decimalsFunction, BlockParameter? blockParameter = null)
    {
        return contractService.DecimalsQueryAsync(decimalsFunction, blockParameter);
    }

    public virtual Task<byte> DecimalsQueryAsync(BlockParameter? blockParameter = null)
    {
        return contractService.DecimalsQueryAsync(blockParameter);
    }

    public virtual Task<BigInteger> AllowedQueryAsync(AllowedFunction allowedFunction, BlockParameter? blockParameter = null)
    {
        return contractService.AllowedQueryAsync(allowedFunction, blockParameter);
    }

    public virtual Task<BigInteger> AllowedQueryAsync(string owner, string spender, BlockParameter? blockParameter = null)
    {
        return contractService.AllowedQueryAsync(owner, spender, blockParameter);
    }

    public virtual Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter? blockParameter = null)
    {
        return contractService.BalanceOfQueryAsync(balanceOfFunction, blockParameter);
    }

    public virtual Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter? blockParameter = null)
    {
        return contractService.BalanceOfQueryAsync(owner, blockParameter);
    }

    public virtual Task<string> TransferRequestAsync(TransferFunction transferFunction)
    {
        return contractService.TransferRequestAsync(transferFunction);
    }

    public virtual Task<string> TransferRequestAsync(string to, BigInteger value)
    {
        return contractService.TransferRequestAsync(to, value);
    }

    public virtual Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction, CancellationToken cancellationToken = default)
    {
        return contractService.TransferRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
    }

    public virtual Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(string to, BigInteger value,
        CancellationToken cancellationToken = default)
    {
        return contractService.TransferRequestAndWaitForReceiptAsync(to, value, cancellationToken);
    }

    public virtual Task<BigInteger> AllowanceQueryAsync(AllowanceFunction allowanceFunction, BlockParameter? blockParameter = null)
    {
        return contractService.AllowanceQueryAsync(allowanceFunction, blockParameter);
    }

    public virtual Task<BigInteger> AllowanceQueryAsync(string owner, string spender, BlockParameter? blockParameter = null)
    {
        return contractService.AllowanceQueryAsync(owner, spender, blockParameter);
    }
}