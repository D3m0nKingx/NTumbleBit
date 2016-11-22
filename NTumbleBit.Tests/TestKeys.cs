﻿using NBitcoin.DataEncoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTumbleBit.Tests
{
	public class TestKeys
	{
		static RsaKey _Default;
		public static RsaKey Default
		{
			get
			{
				if(_Default == null)
				{
					_Default = new RsaKey(Encoders.Hex.DecodeData("308204bd020100300d06092a864886f70d0101010500048204a7308204a30201000282010100ae4e343c895fd65a8bc0c3ef087fe50d9c53c9708ea18a421af21e140de40da4866a9aa448c60ec8dbc54a6a284d0d62258ac3aac5be5e5ed561ecd2ea09be047bc7b2b303e6d9ecba0bf3fbfa7667940fc61b41c4ed505787e00b88854f5793e6aa9f48a4b0512ba3f16fa6fdfa83e38038b8dace719a5400e96d0180c4d7560a17b96ed5a95fc0ae711968d346930319b35bb6b5b38d977a7429ac00d9accf44634d07e72a9e9b9e8f188f01d06177530d073306166ec9fd9712ea5fe56ef80c5422e36eb1864188f9c9ea8ae06e2606cf2f830da704be7066e064c8598ad8029a39c4737a4b31750e05e9605a2cb4b44c9036b372274d437dbe48af43c693020301000102820100496cca16622c0be8d28c1e3d58104015ceaf80e0b84496302897ab51f95402e736743bb64ead97d6c6b542169be97164d1b9b598ff79a4d93ffbe33e29b676e3fe9c6dcb792e4ac8acca9239a8152ea6b14a5b7b06108dd2817b40807edfa05dbe424b9cd73b2ac63e665b09365dcc270e8156655da77f4239ac1aee12275929c30ecfbab1e84dff2cea7c3aeba6fbe22ff9bbe06656c392510b02fa4ee9127d10614a5afeb07456e9bf7e9ce3fb03751649fc12d6f69d64a41c9edbaa60f9cb0b20bb55780a64b4a684ebcb9ca1dedec1511a22be7d07df718e1508f3517f0fc1d91c06edb8a6a4932937bf1f50fa6e564379f28e8e2880c89a6f394ef87cf902818100ee3a51351a5b1203d7f80095d4e56b8d3c65b3496133b5501c34293f919b798a4c401cc6464849e5b79f142b88330e232c9f265804b352eb9d6ddf8e07f1d0633b906e50b1b32f0e21e2ebeac36556e1a2dee4226065f665a955914c793e04c33f1a7544506d89c8f17e2289dd68757ed129e60b99a3ca17673bbfd1c4f46b4f02818100bb4f18a16d038ba88a3bc5f0320a537331f517bf9206388a894153d7321c9c171b2fa764b2d51dd917a518de7c3d5d44b8e090464ff661277ab7670bbb285a7d4a64306732b0168a28ad39e3c550d4412bc13acee63606eee9b74a566cf6641ef95e03d5b848c6bcf70cd0a5d1a2502f36a8bdc0add7d4d070c355e6f0d24f7d02818034edee170f5906a2a5fc6b1cdf256e04fe5356474a7a73a16df2c4eb63cd986e7acc8fd819cb7be7b7297810c7fd17fa06b30190f2d268ed029863e029b1b76c24d2cd3fce8b923be0998b7328a0be71f97eee4f18fdee85dddeae1ec09d5fef8578ba6f48335e36b03927315c691619ec1d1408a5c5376485c247b732bc5f8f02818023e5b4c2bb31c2c23a3bda637e339c6aa7586184c5678bce811f9401da08c1a16c0466005685a182c9954a7ed930a97f522f3777423be5c2bb320afda490c746dbcaf7bbcf6b0fe6ca84e8634e9d7f103e6279f2cd0beda83c0274acbb953cfaf2afa1ec83b4eee1a8373c858af7a0866be34afa7256bae277b9f7ec9a9ab3c102818100bfbedee78c33706171c7a6e916999fedaa751ee3962cf531d54529af4c1060fe21b8c50688779dad41cc2ddf8a5c0cd8d6d6175f22de233866888d476565be559d86966c5692845c40104194bd9a4329ea71bbc20bdaadbfc81f9b91c09dbfa65528bfff2eed02764181e854589f228aef1b712e11cdbf34979279b6969e50ae"));
				}
				return _Default;
			}
		}

		static RsaKey _Default2;
		public static RsaKey Default2
		{
			get
			{
				if(_Default2 == null)
				{
					_Default2 = new RsaKey(Encoders.Hex.DecodeData("308204bd020100300d06092a864886f70d0101010500048204a7308204a30201000282010100e1d61e2c2c3b6fe904e97cb5c0e21c45593aace8e80769bed041722730d7100c43a6d629e38d39b62b1fff18d00c755a73506d43a0074f13542973af0c090b55c40fe938b04fb7a0a4ed2774c89f28f0d7e49cfa9578ca6dd4d4fb10fa35ac8d04fdedd1e5ca4c8e98941b792c02389f52321800321fb0d4d5a41a9f3339f45117ae670f52a4ebfbb7db5f8294a4ddc2f051ff86099cfe344048ca16ff5fed5942329c1255ef328a98458f8f0e3013f0bac2b42ec436c292621899db311fe0a8408ff0aa980a6bd738060d37c061166706f2252f5c8df9df294be3514219dbb556180da92394ae097b2fa64d769081dd2a1c2ef241f21e245ca88e18f20933670203010001028201007d7cbcc74eccb82282d83ab3c3b9e07ba859323b38b2e5cf6168fc454a9e360c9a8ad9f5ecbb4c962ce05a9f2efbbd39c559ab5d284ee76196227265920a7481f3afe3a7dc506f78942c33007179ff05d4f0f3494a451436734ce53549d3094e52b7c6ae1b418dc8ae7f9dc476efc506c265937088699398b01dbfad3689bd77469efb80cb6ee8c185be2bc752348c1db0a843b1cc5f02c44ff0e125cf611d74e66b5bbc839ed23e8afadc70b1eb99cb2cf55c03a33664852756871361f4324db048579ce3e5de7028e715ce76ce5f55e88b0a1e7ca0c2c548612a6ecbbfad09f6ef69f4853aa949a1ade778a03d9cd0ead43c8aec55a972b426c4f22810560102818100f75ff29604b043f0a6d08372fc9af5400672fccb07c41acd5b80e5b39aceffe04b23294bb154c1b220771bd85bc783c58f579e3a866e861d98fb57c1bc2a95c6b2fa36bf8c3b5ac334af24778563d2313a51a6f346d65756b2cccbcd0e4f35b9975d04f14f10e7a17d8980a87cf335e008f6b194b288300ccb51362516305dc302818100e9b5eb7a27d3e557398962fef61971280dd27eb91839835284202e03ab9a82b046eafd84bc41a787474326ec22b0044f90a50fb45bf7df5b0ea7f46b809a4491acec80f7acdba5d81f85425b5c87af08c0b29556950c38fc7639e5e9f393cf4eb9d3ff779c64da9f40bed3f0818e786d8dc394fde437d6301ad5d140ed60458d02818042ec603299be1e0342fdf231ef88f48487ba200dc56216662c3528ef78183c3d2fd6a95b62f42d1ac591b3a4cadfa514937cfebf9292e011adcb81a85601a75784201123ad0a79b989cd402e5d95edcd879b8371195eef6df31d589d771b92cb4cd9cb76850f6bbad2bd9a62fabac97e7cae50c88bac3063a5b5a8d24bb8760502818100cad4f60f486da087390a417ea1bba6f76a379b7facc48d7299f50bba67be6b59edd2984010dab238b7e251ef72936cca58f0c85671d3086810aa3778ed5df5d0b0517a047a630ee629451038167033bad6f2a6a5442a1d730e706557cbec26695ee1dcbfc45dcb57976b86a91ee7b520ef7e24daccaca11992d0ab113c72e7290281803965512a69e570140f300883ce5bb199e728eac61bf8b47ac268850ce0346baf2e75fadb0eb617783862a2b0a8ee0dfaea6117033ca13b326c88c06bb170a067baff195becd7486957e8d3fe4863ce88c566914e3b655fff2218775a0c2c97b461e0524d7c35f2619986d15cba28990dc593e694899dbef84221931fcd31c1aa"));
				}
				return _Default2;
			}
		}
	}
}
