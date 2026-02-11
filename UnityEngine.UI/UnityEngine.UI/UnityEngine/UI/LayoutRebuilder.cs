using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x02000027 RID: 39
	public class LayoutRebuilder : Object
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x00019858 File Offset: 0x00017A58
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutRebuilder()
		{
			Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutRebuilder");
			LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "m_ToRebuild");
			LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "m_CachedHashFromTransform");
			LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "s_Rebuilders");
			LayoutRebuilder.NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664063);
			LayoutRebuilder.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664064);
			LayoutRebuilder.NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664066);
			LayoutRebuilder.NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664067);
			LayoutRebuilder.NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664068);
			LayoutRebuilder.NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664069);
			LayoutRebuilder.NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664070);
			LayoutRebuilder.NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664071);
			LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664072);
			LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664073);
			LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664074);
			LayoutRebuilder.NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664075);
			LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664076);
			LayoutRebuilder.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664077);
			LayoutRebuilder.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664078);
			LayoutRebuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664079);
			LayoutRebuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664080);
			LayoutRebuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664081);
			LayoutRebuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100664082);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00019A38 File Offset: 0x00017C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088833, XrefRangeEnd = 1088834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(RectTransform controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00019A7C File Offset: 0x00017C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088834, XrefRangeEnd = 1088835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00019AB0 File Offset: 0x00017CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088835, XrefRangeEnd = 1088839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReapplyDrivenProperties(RectTransform driven)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00019AE8 File Offset: 0x00017CE8
		public unsafe virtual Transform transform
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00019B28 File Offset: 0x00017D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088839, XrefRangeEnd = 1088843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00019B64 File Offset: 0x00017D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1088862, RefRangeEnd = 1088864, XrefRangeStart = 1088843, XrefRangeEnd = 1088862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StripDisabledBehavioursFromList(List<Component> components)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00019B9C File Offset: 0x00017D9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1088878, RefRangeEnd = 1088882, XrefRangeStart = 1088864, XrefRangeEnd = 1088878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layoutRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00019BD4 File Offset: 0x00017DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1088940, RefRangeEnd = 1088941, XrefRangeStart = 1088882, XrefRangeEnd = 1088940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00019C14 File Offset: 0x00017E14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1089000, RefRangeEnd = 1089003, XrefRangeStart = 1088941, XrefRangeEnd = 1089000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00019C68 File Offset: 0x00017E68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1089046, RefRangeEnd = 1089049, XrefRangeStart = 1089003, XrefRangeEnd = 1089046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00019CBC File Offset: 0x00017EBC
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1089129, RefRangeEnd = 1089149, XrefRangeStart = 1089049, XrefRangeEnd = 1089129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkLayoutForRebuild(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00019CF4 File Offset: 0x00017EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089175, RefRangeEnd = 1089176, XrefRangeStart = 1089149, XrefRangeEnd = 1089175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layoutRoot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00019D48 File Offset: 0x00017F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089176, XrefRangeEnd = 1089198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkLayoutRootForRebuild(RectTransform controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00019D80 File Offset: 0x00017F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089198, XrefRangeEnd = 1089206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00019DB4 File Offset: 0x00017FB4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00019DE8 File Offset: 0x00017FE8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00019E30 File Offset: 0x00018030
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00019E88 File Offset: 0x00018088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089206, XrefRangeEnd = 1089210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00019ECC File Offset: 0x000180CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutRebuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00003A1A File Offset: 0x00001C1A
		public LayoutRebuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00019F08 File Offset: 0x00018108
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00003A23 File Offset: 0x00001C23
		public unsafe RectTransform m_ToRebuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00019F38 File Offset: 0x00018138
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00003A42 File Offset: 0x00001C42
		public unsafe int m_CachedHashFromTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00019F60 File Offset: 0x00018160
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00003A5D File Offset: 0x00001C5D
		public unsafe static ObjectPool<LayoutRebuilder> s_Rebuilders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LayoutRebuilder>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_m_ToRebuild;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedHashFromTransform;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_s_Rebuilders;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A5 RID: 165
		[ObfuscatedName("UnityEngine.UI.LayoutRebuilder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000C86 RID: 3206 RVA: 0x00036930 File Offset: 0x00034B30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr);
				LayoutRebuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__10_0");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_0");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_1");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_2");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_3");
				LayoutRebuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664084);
				LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_LayoutRebuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664085);
				LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_LayoutRebuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664086);
				LayoutRebuilder.__c.NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664087);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664088);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664089);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664090);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100664091);
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x00036A74 File Offset: 0x00034C74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x00036AB0 File Offset: 0x00034CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088793, XrefRangeEnd = 1088797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LayoutRebuilder __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_LayoutRebuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LayoutRebuilder>(intPtr3) : null;
			}

			// Token: 0x06000C89 RID: 3209 RVA: 0x00036AF0 File Offset: 0x00034CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088797, XrefRangeEnd = 1088798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__5_1(LayoutRebuilder x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_LayoutRebuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x00036B34 File Offset: 0x00034D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088798, XrefRangeEnd = 1088801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StripDisabledBehavioursFromList_b__10_0(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x00036B84 File Offset: 0x00034D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088801, XrefRangeEnd = 1088809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_0(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x00036BC8 File Offset: 0x00034DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088809, XrefRangeEnd = 1088817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_1(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x00036C0C File Offset: 0x00034E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088817, XrefRangeEnd = 1088825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_2(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x00036C50 File Offset: 0x00034E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088825, XrefRangeEnd = 1088833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_3(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C8F RID: 3215 RVA: 0x00006AD3 File Offset: 0x00004CD3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00036C94 File Offset: 0x00034E94
			// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00006ADC File Offset: 0x00004CDC
			public unsafe static LayoutRebuilder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutRebuilder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00036CBC File Offset: 0x00034EBC
			// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00006AEE File Offset: 0x00004CEE
			public unsafe static Predicate<Component> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00036CE4 File Offset: 0x00034EE4
			// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00006B00 File Offset: 0x00004D00
			public unsafe static UnityAction<Component> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00036D0C File Offset: 0x00034F0C
			// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00006B12 File Offset: 0x00004D12
			public unsafe static UnityAction<Component> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00036D34 File Offset: 0x00034F34
			// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00006B24 File Offset: 0x00004D24
			public unsafe static UnityAction<Component> __9__12_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00036D5C File Offset: 0x00034F5C
			// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00006B36 File Offset: 0x00004D36
			public unsafe static UnityAction<Component> __9__12_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009B2 RID: 2482
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009B3 RID: 2483
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040009B4 RID: 2484
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x040009B5 RID: 2485
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x040009B6 RID: 2486
			private static readonly IntPtr NativeFieldInfoPtr___9__12_2;

			// Token: 0x040009B7 RID: 2487
			private static readonly IntPtr NativeFieldInfoPtr___9__12_3;

			// Token: 0x040009B8 RID: 2488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009B9 RID: 2489
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_LayoutRebuilder_0;

			// Token: 0x040009BA RID: 2490
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_LayoutRebuilder_0;

			// Token: 0x040009BB RID: 2491
			private static readonly IntPtr NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0;

			// Token: 0x040009BC RID: 2492
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0;

			// Token: 0x040009BD RID: 2493
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0;

			// Token: 0x040009BE RID: 2494
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0;

			// Token: 0x040009BF RID: 2495
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0;
		}
	}
}
