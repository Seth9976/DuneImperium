using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.datarenderers
{
	// Token: 0x0200016A RID: 362
	public class ApplyColorRenderer : VersionedSubscriber<ColorDataComponent>
	{
		// Token: 0x06001020 RID: 4128 RVA: 0x000508FC File Offset: 0x0004EAFC
		// Note: this type is marked as 'beforefieldinit'.
		static ApplyColorRenderer()
		{
			Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "ApplyColorRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr);
			ApplyColorRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr, "image");
			ApplyColorRenderer.NativeFieldInfoPtr_playerColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr, "playerColors");
			ApplyColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr, 100665568);
			ApplyColorRenderer.NativeMethodInfoPtr_OverrideColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr, 100665569);
			ApplyColorRenderer.NativeMethodInfoPtr_MatchData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr, 100665570);
			ApplyColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr, 100665571);
			ApplyColorRenderer.NativeMethodInfoPtr__MatchData_b__4_0_Private_Boolean_StringColorUnityColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr, 100665572);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x000509B8 File Offset: 0x0004EBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513824, XrefRangeEnd = 513834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyColorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000509F4 File Offset: 0x0004EBF4
		[CallerCount(0)]
		public unsafe void OverrideColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyColorRenderer.NativeMethodInfoPtr_OverrideColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00050A34 File Offset: 0x0004EC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MatchData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyColorRenderer.NativeMethodInfoPtr_MatchData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00050A68 File Offset: 0x0004EC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513834, XrefRangeEnd = 513837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplyColorRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyColorRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyColorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00050AA4 File Offset: 0x0004ECA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513837, XrefRangeEnd = 513840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _MatchData_b__4_0(StringColorPalette.StringColorUnityColorPair playerColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerColor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyColorRenderer.NativeMethodInfoPtr__MatchData_b__4_0_Private_Boolean_StringColorUnityColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00009D01 File Offset: 0x00007F01
		public ApplyColorRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x00050AF4 File Offset: 0x0004ECF4
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x00009D0A File Offset: 0x00007F0A
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyColorRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyColorRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00050B24 File Offset: 0x0004ED24
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x00009D29 File Offset: 0x00007F29
		public unsafe StringColorPalette playerColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyColorRenderer.NativeFieldInfoPtr_playerColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringColorPalette>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyColorRenderer.NativeFieldInfoPtr_playerColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeFieldInfoPtr_playerColors;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_OverrideColor_Public_Void_Color_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_MatchData_Public_Void_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr__MatchData_b__4_0_Private_Boolean_StringColorUnityColorPair_0;
	}
}
