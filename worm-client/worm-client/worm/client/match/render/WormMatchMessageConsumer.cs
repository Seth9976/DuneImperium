using System;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.client.match.render
{
	// Token: 0x0200029B RID: 667
	public class WormMatchMessageConsumer : DBGMatchMessageConsumer
	{
		// Token: 0x06001B2C RID: 6956 RVA: 0x0006B81C File Offset: 0x00069A1C
		// Note: this type is marked as 'beforefieldinit'.
		static WormMatchMessageConsumer()
		{
			Il2CppClassPointerStore<WormMatchMessageConsumer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "WormMatchMessageConsumer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatchMessageConsumer>.NativeClassPtr);
			WormMatchMessageConsumer.NativeMethodInfoPtr_createSequenceParser_Protected_Virtual_ISequenceToCommandFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchMessageConsumer>.NativeClassPtr, 100667253);
			WormMatchMessageConsumer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchMessageConsumer>.NativeClassPtr, 100667254);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0006B874 File Offset: 0x00069A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724192, XrefRangeEnd = 724196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISequenceToCommandFactory createSequenceParser()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchMessageConsumer.NativeMethodInfoPtr_createSequenceParser_Protected_Virtual_ISequenceToCommandFactory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISequenceToCommandFactory>(intPtr3) : null;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0006B8C0 File Offset: 0x00069AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724196, XrefRangeEnd = 724200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchMessageConsumer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchMessageConsumer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchMessageConsumer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0000FC1A File Offset: 0x0000DE1A
		public WormMatchMessageConsumer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_createSequenceParser_Protected_Virtual_ISequenceToCommandFactory_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
