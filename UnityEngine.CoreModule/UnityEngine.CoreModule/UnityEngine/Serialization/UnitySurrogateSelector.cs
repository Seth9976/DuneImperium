using System;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x0200031F RID: 799
	public class UnitySurrogateSelector
	{
		// Token: 0x06002E04 RID: 11780 RVA: 0x00012604 File Offset: 0x00010804
		public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x00012611 File Offset: 0x00010811
		public void ChainSelector(ISurrogateSelector selector)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00012619 File Offset: 0x00010819
		public ISurrogateSelector GetNextSelector()
		{
			throw new NotImplementedException();
		}
	}
}
