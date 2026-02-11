using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.canis.dbg_client.prompts
{
	// Token: 0x0200006D RID: 109
	public class PlatformPromptVisualConfigHandler : MonoBehaviour
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x0002A6EC File Offset: 0x000288EC
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformPromptVisualConfigHandler()
		{
			Il2CppClassPointerStore<PlatformPromptVisualConfigHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.prompts", "PlatformPromptVisualConfigHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler>.NativeClassPtr);
			PlatformPromptVisualConfigHandler.NativeFieldInfoPtr_platformConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler>.NativeClassPtr, "platformConfigs");
			PlatformPromptVisualConfigHandler.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler>.NativeClassPtr, 100663920);
			PlatformPromptVisualConfigHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler>.NativeClassPtr, 100663921);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0002A758 File Offset: 0x00028958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500369, XrefRangeEnd = 500434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformPromptVisualConfigHandler.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0002A78C File Offset: 0x0002898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500434, XrefRangeEnd = 500509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformPromptVisualConfigHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformPromptVisualConfigHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00003D4A File Offset: 0x00001F4A
		public PlatformPromptVisualConfigHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0002A7C8 File Offset: 0x000289C8
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00003D53 File Offset: 0x00001F53
		public unsafe List<PlatformConfig> platformConfigs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformPromptVisualConfigHandler.NativeFieldInfoPtr_platformConfigs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformPromptVisualConfigHandler.NativeFieldInfoPtr_platformConfigs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_platformConfigs;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002F0 RID: 752
		[ObfuscatedName("dwd.canis.dbg_client.prompts.PlatformPromptVisualConfigHandler+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002381 RID: 9089 RVA: 0x00092B34 File Offset: 0x00090D34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<PlatformPromptVisualConfigHandler.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler.__c__DisplayClass1_0>.NativeClassPtr);
				PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_currentPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler.__c__DisplayClass1_0>.NativeClassPtr, "currentPlatform");
				PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler.__c__DisplayClass1_0>.NativeClassPtr, "<>9__0");
				PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler.__c__DisplayClass1_0>.NativeClassPtr, 100663922);
				PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__Start_b__0_Internal_Boolean_PlatformConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler.__c__DisplayClass1_0>.NativeClassPtr, 100663923);
			}

			// Token: 0x06002382 RID: 9090 RVA: 0x00092BB0 File Offset: 0x00090DB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformPromptVisualConfigHandler.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002383 RID: 9091 RVA: 0x00092BEC File Offset: 0x00090DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500365, XrefRangeEnd = 500369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__0(PlatformConfig platformConfig)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(platformConfig));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeMethodInfoPtr__Start_b__0_Internal_Boolean_PlatformConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002384 RID: 9092 RVA: 0x000127E3 File Offset: 0x000109E3
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009A4 RID: 2468
			// (get) Token: 0x06002385 RID: 9093 RVA: 0x00092C40 File Offset: 0x00090E40
			// (set) Token: 0x06002386 RID: 9094 RVA: 0x000127EC File Offset: 0x000109EC
			public unsafe RuntimePlatform currentPlatform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_currentPlatform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeFieldInfoPtr_currentPlatform)) = value;
				}
			}

			// Token: 0x170009A5 RID: 2469
			// (get) Token: 0x06002387 RID: 9095 RVA: 0x00092C68 File Offset: 0x00090E68
			// (set) Token: 0x06002388 RID: 9096 RVA: 0x00012807 File Offset: 0x00010A07
			public unsafe Func<PlatformConfig, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlatformConfig, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformPromptVisualConfigHandler.__c__DisplayClass1_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001652 RID: 5714
			private static readonly IntPtr NativeFieldInfoPtr_currentPlatform;

			// Token: 0x04001653 RID: 5715
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04001654 RID: 5716
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001655 RID: 5717
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Boolean_PlatformConfig_0;
		}
	}
}
