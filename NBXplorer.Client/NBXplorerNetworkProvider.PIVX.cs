using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitPIVX(ChainName networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.PIVX.Instance, networkType)
			{
				MinRPCVersion = 140200,
				CoinType = networkType == ChainName.Mainnet ? new KeyPath("2'") : new KeyPath("1'"),
			});
		}

		public NBXplorerNetwork GetPIVX()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.PIVX.Instance.CryptoCode);
		}
	}
}
