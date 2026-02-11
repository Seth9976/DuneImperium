using System;
using boardgames.moz;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001AF RID: 431
	public class CombinedTooltipSource : MonoBehaviour
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x00051EB4 File Offset: 0x000500B4
		// Note: this type is marked as 'beforefieldinit'.
		static CombinedTooltipSource()
		{
			Il2CppClassPointerStore<CombinedTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "CombinedTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombinedTooltipSource>.NativeClassPtr);
			CombinedTooltipSource.NativeFieldInfoPtr_tooltips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombinedTooltipSource>.NativeClassPtr, "tooltips");
			CombinedTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombinedTooltipSource>.NativeClassPtr, 100665897);
			CombinedTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombinedTooltipSource>.NativeClassPtr, 100665898);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00051F20 File Offset: 0x00050120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712664, XrefRangeEnd = 712702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombinedTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00051F58 File Offset: 0x00050158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712702, XrefRangeEnd = 712707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombinedTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombinedTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombinedTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		public CombinedTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00051F94 File Offset: 0x00050194
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x0000BDBD File Offset: 0x00009FBD
		public unsafe Il2CppReferenceArray<DBGTooltip> tooltips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombinedTooltipSource.NativeFieldInfoPtr_tooltips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DBGTooltip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombinedTooltipSource.NativeFieldInfoPtr_tooltips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeFieldInfoPtr_tooltips;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C4 RID: 964
		[ObfuscatedName("worm.match.components.CombinedTooltipSource+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060026F1 RID: 9969 RVA: 0x0008E4A8 File Offset: 0x0008C6A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombinedTooltipSource>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr);
				CombinedTooltipSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr, "<>9");
				CombinedTooltipSource.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr, "<>9__1_0");
				CombinedTooltipSource.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr, "<>9__1_1");
				CombinedTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr, 100665900);
				CombinedTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__1_0_Internal_Boolean_DBGTooltip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr, 100665901);
				CombinedTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__1_1_Internal_String_DBGTooltip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr, 100665902);
			}

			// Token: 0x060026F2 RID: 9970 RVA: 0x0008E54C File Offset: 0x0008C74C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombinedTooltipSource.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombinedTooltipSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026F3 RID: 9971 RVA: 0x0008E588 File Offset: 0x0008C788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712660, XrefRangeEnd = 712662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLocalizedTooltip_b__1_0(DBGTooltip t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombinedTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__1_0_Internal_Boolean_DBGTooltip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026F4 RID: 9972 RVA: 0x0008E5D8 File Offset: 0x0008C7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712662, XrefRangeEnd = 712664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetLocalizedTooltip_b__1_1(DBGTooltip t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombinedTooltipSource.__c.NativeMethodInfoPtr__GetLocalizedTooltip_b__1_1_Internal_String_DBGTooltip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060026F5 RID: 9973 RVA: 0x00015751 File Offset: 0x00013951
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AD4 RID: 2772
			// (get) Token: 0x060026F6 RID: 9974 RVA: 0x0008E620 File Offset: 0x0008C820
			// (set) Token: 0x060026F7 RID: 9975 RVA: 0x0001575A File Offset: 0x0001395A
			public unsafe static CombinedTooltipSource.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombinedTooltipSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombinedTooltipSource.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombinedTooltipSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD5 RID: 2773
			// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0008E648 File Offset: 0x0008C848
			// (set) Token: 0x060026F9 RID: 9977 RVA: 0x0001576C File Offset: 0x0001396C
			public unsafe static Func<DBGTooltip, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombinedTooltipSource.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DBGTooltip, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombinedTooltipSource.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AD6 RID: 2774
			// (get) Token: 0x060026FA RID: 9978 RVA: 0x0008E670 File Offset: 0x0008C870
			// (set) Token: 0x060026FB RID: 9979 RVA: 0x0001577E File Offset: 0x0001397E
			public unsafe static Func<DBGTooltip, string> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CombinedTooltipSource.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DBGTooltip, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CombinedTooltipSource.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400166C RID: 5740
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400166D RID: 5741
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400166E RID: 5742
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x0400166F RID: 5743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001670 RID: 5744
			private static readonly IntPtr NativeMethodInfoPtr__GetLocalizedTooltip_b__1_0_Internal_Boolean_DBGTooltip_0;

			// Token: 0x04001671 RID: 5745
			private static readonly IntPtr NativeMethodInfoPtr__GetLocalizedTooltip_b__1_1_Internal_String_DBGTooltip_0;
		}
	}
}
