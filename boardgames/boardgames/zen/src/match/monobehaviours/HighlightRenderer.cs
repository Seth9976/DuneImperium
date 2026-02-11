using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x02000070 RID: 112
	public class HighlightRenderer : MonoBehaviour
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x00023490 File Offset: 0x00021690
		// Note: this type is marked as 'beforefieldinit'.
		static HighlightRenderer()
		{
			Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "HighlightRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr);
			HighlightRenderer.NativeFieldInfoPtr_fxHelpers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, "fxHelpers");
			HighlightRenderer.NativeFieldInfoPtr_views = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, "views");
			HighlightRenderer.NativeFieldInfoPtr_HintInteractive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, "HintInteractive");
			HighlightRenderer.NativeFieldInfoPtr_interactionResponders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, "interactionResponders");
			HighlightRenderer.NativeMethodInfoPtr_RegisterHelper_Public_Void_FXHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, 100664243);
			HighlightRenderer.NativeMethodInfoPtr_RegisterView_Public_Void_String_VoodooView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, 100664244);
			HighlightRenderer.NativeMethodInfoPtr_GetView_Public_VoodooView_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, 100664245);
			HighlightRenderer.NativeMethodInfoPtr_SetVisible_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, 100664246);
			HighlightRenderer.NativeMethodInfoPtr_AddInteractionResponder_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, 100664247);
			HighlightRenderer.NativeMethodInfoPtr_RespondToInteraction_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, 100664248);
			HighlightRenderer.NativeMethodInfoPtr_helperForKey_Public_FXHelper_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, 100664249);
			HighlightRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr, 100664250);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000235B0 File Offset: 0x000217B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 988268, RefRangeEnd = 988269, XrefRangeStart = 988262, XrefRangeEnd = 988268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterHelper(FXHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(helper);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightRenderer.NativeMethodInfoPtr_RegisterHelper_Public_Void_FXHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000235F4 File Offset: 0x000217F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 988273, RefRangeEnd = 988274, XrefRangeStart = 988269, XrefRangeEnd = 988273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterView(string key, VoodooView view)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(view);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightRenderer.NativeMethodInfoPtr_RegisterView_Public_Void_String_VoodooView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00023648 File Offset: 0x00021848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 988277, RefRangeEnd = 988278, XrefRangeStart = 988274, XrefRangeEnd = 988277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooView GetView(string viewKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(viewKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightRenderer.NativeMethodInfoPtr_GetView_Public_VoodooView_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoodooView>(intPtr3) : null;
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00023698 File Offset: 0x00021898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 988284, RefRangeEnd = 988286, XrefRangeStart = 988278, XrefRangeEnd = 988284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(string key, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightRenderer.NativeMethodInfoPtr_SetVisible_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000236E8 File Offset: 0x000218E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988286, XrefRangeEnd = 988296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInteractionResponder(string key, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightRenderer.NativeMethodInfoPtr_AddInteractionResponder_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00023738 File Offset: 0x00021938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988296, XrefRangeEnd = 988314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RespondToInteraction(bool isInteracting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isInteracting;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightRenderer.NativeMethodInfoPtr_RespondToInteraction_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00023778 File Offset: 0x00021978
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 988325, RefRangeEnd = 988329, XrefRangeStart = 988314, XrefRangeEnd = 988325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXHelper helperForKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightRenderer.NativeMethodInfoPtr_helperForKey_Public_FXHelper_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FXHelper>(intPtr3) : null;
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000237C8 File Offset: 0x000219C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988329, XrefRangeEnd = 988351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighlightRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighlightRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00004B51 File Offset: 0x00002D51
		public HighlightRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00023804 File Offset: 0x00021A04
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00004B5A File Offset: 0x00002D5A
		public unsafe List<FXHelper> fxHelpers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighlightRenderer.NativeFieldInfoPtr_fxHelpers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FXHelper>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighlightRenderer.NativeFieldInfoPtr_fxHelpers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00023834 File Offset: 0x00021A34
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00004B79 File Offset: 0x00002D79
		public unsafe Dictionary<string, VoodooView> views
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighlightRenderer.NativeFieldInfoPtr_views);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, VoodooView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighlightRenderer.NativeFieldInfoPtr_views), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00023864 File Offset: 0x00021A64
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00004B98 File Offset: 0x00002D98
		public unsafe static string HintInteractive
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HighlightRenderer.NativeFieldInfoPtr_HintInteractive, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HighlightRenderer.NativeFieldInfoPtr_HintInteractive, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00023884 File Offset: 0x00021A84
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00004BAA File Offset: 0x00002DAA
		public unsafe Dictionary<string, FXUnit> interactionResponders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighlightRenderer.NativeFieldInfoPtr_interactionResponders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FXUnit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HighlightRenderer.NativeFieldInfoPtr_interactionResponders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_fxHelpers;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_views;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_HintInteractive;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_interactionResponders;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_RegisterHelper_Public_Void_FXHelper_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_RegisterView_Public_Void_String_VoodooView_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_GetView_Public_VoodooView_String_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_String_Boolean_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_AddInteractionResponder_Public_Void_String_Boolean_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_RespondToInteraction_Public_Void_Boolean_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_helperForKey_Public_FXHelper_String_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
