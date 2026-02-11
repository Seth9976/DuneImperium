using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x02000201 RID: 513
	public class WormLeaderSelectTypeTooltipSource : MonoBehaviour
	{
		// Token: 0x060016B7 RID: 5815 RVA: 0x0005D044 File Offset: 0x0005B244
		// Note: this type is marked as 'beforefieldinit'.
		static WormLeaderSelectTypeTooltipSource()
		{
			Il2CppClassPointerStore<WormLeaderSelectTypeTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormLeaderSelectTypeTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLeaderSelectTypeTooltipSource>.NativeClassPtr);
			WormLeaderSelectTypeTooltipSource.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectTypeTooltipSource>.NativeClassPtr, "args");
			WormLeaderSelectTypeTooltipSource.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormLeaderSelectTypeTooltipSource>.NativeClassPtr, "tooltip");
			WormLeaderSelectTypeTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectTypeTooltipSource>.NativeClassPtr, 100666459);
			WormLeaderSelectTypeTooltipSource.NativeMethodInfoPtr_SetArgs_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectTypeTooltipSource>.NativeClassPtr, 100666460);
			WormLeaderSelectTypeTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLeaderSelectTypeTooltipSource>.NativeClassPtr, 100666461);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0005D0D8 File Offset: 0x0005B2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716864, XrefRangeEnd = 716871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectTypeTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0005D110 File Offset: 0x0005B310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArgs(Il2CppReferenceArray<global::Il2CppSystem.Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectTypeTooltipSource.NativeMethodInfoPtr_SetArgs_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0005D154 File Offset: 0x0005B354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716871, XrefRangeEnd = 716875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLeaderSelectTypeTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLeaderSelectTypeTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLeaderSelectTypeTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0000DA86 File Offset: 0x0000BC86
		public WormLeaderSelectTypeTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x0005D190 File Offset: 0x0005B390
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x0000DA8F File Offset: 0x0000BC8F
		public unsafe Il2CppReferenceArray<global::Il2CppSystem.Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectTypeTooltipSource.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectTypeTooltipSource.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x0005D1C0 File Offset: 0x0005B3C0
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x0000DAAE File Offset: 0x0000BCAE
		public unsafe string tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectTypeTooltipSource.NativeFieldInfoPtr_tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormLeaderSelectTypeTooltipSource.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_SetArgs_Public_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
