using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200013C RID: 316
	public class DebugUIHandlerVector3 : DebugUIHandlerWidget
	{
		// Token: 0x06001486 RID: 5254 RVA: 0x0005AE20 File Offset: 0x00059020
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerVector3()
		{
			Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr);
			DebugUIHandlerVector3.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, "nameLabel");
			DebugUIHandlerVector3.NativeFieldInfoPtr_valueToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, "valueToggle");
			DebugUIHandlerVector3.NativeFieldInfoPtr_fieldX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, "fieldX");
			DebugUIHandlerVector3.NativeFieldInfoPtr_fieldY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, "fieldY");
			DebugUIHandlerVector3.NativeFieldInfoPtr_fieldZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, "fieldZ");
			DebugUIHandlerVector3.NativeFieldInfoPtr_m_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, "m_Field");
			DebugUIHandlerVector3.NativeFieldInfoPtr_m_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, "m_Container");
			DebugUIHandlerVector3.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666248);
			DebugUIHandlerVector3.NativeMethodInfoPtr_SetValue_Private_Void_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666249);
			DebugUIHandlerVector3.NativeMethodInfoPtr_SetupSettings_Private_Void_DebugUIHandlerIndirectFloatField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666250);
			DebugUIHandlerVector3.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666251);
			DebugUIHandlerVector3.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666252);
			DebugUIHandlerVector3.NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666253);
			DebugUIHandlerVector3.NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666254);
			DebugUIHandlerVector3.NativeMethodInfoPtr_OnAction_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666255);
			DebugUIHandlerVector3.NativeMethodInfoPtr_Next_Public_Virtual_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666256);
			DebugUIHandlerVector3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666257);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_0_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666258);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666259);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_2_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666260);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666261);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_4_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666262);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_5_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666263);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetupSettings_b__9_0_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666264);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetupSettings_b__9_1_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666265);
			DebugUIHandlerVector3.NativeMethodInfoPtr__SetupSettings_b__9_2_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr, 100666266);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0005B058 File Offset: 0x00059258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981618, XrefRangeEnd = 981673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerVector3.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0005B0A8 File Offset: 0x000592A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981673, XrefRangeEnd = 981676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(float v, bool x = false, bool y = false, bool z = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr_SetValue_Private_Void_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0005B110 File Offset: 0x00059310
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 981698, RefRangeEnd = 981701, XrefRangeStart = 981676, XrefRangeEnd = 981698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSettings(DebugUIHandlerIndirectFloatField field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr_SetupSettings_Private_Void_DebugUIHandlerIndirectFloatField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0005B154 File Offset: 0x00059354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981701, XrefRangeEnd = 981708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromNext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previous);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerVector3.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0005B1BC File Offset: 0x000593BC
		[CallerCount(0)]
		public unsafe override void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerVector3.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0005B1F8 File Offset: 0x000593F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnIncrement(bool fast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerVector3.NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0005B244 File Offset: 0x00059444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDecrement(bool fast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerVector3.NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0005B290 File Offset: 0x00059490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerVector3.NativeMethodInfoPtr_OnAction_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0005B2CC File Offset: 0x000594CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981708, XrefRangeEnd = 981716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DebugUIHandlerWidget Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerVector3.NativeMethodInfoPtr_Next_Public_Virtual_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerWidget>(intPtr3) : null;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0005B318 File Offset: 0x00059518
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerVector3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerVector3>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0005B354 File Offset: 0x00059554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981716, XrefRangeEnd = 981719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _SetWidget_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_0_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0005B390 File Offset: 0x00059590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981719, XrefRangeEnd = 981722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetWidget_b__7_1(float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0005B3D0 File Offset: 0x000595D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981722, XrefRangeEnd = 981725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _SetWidget_b__7_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_2_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0005B40C File Offset: 0x0005960C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981725, XrefRangeEnd = 981728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetWidget_b__7_3(float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0005B44C File Offset: 0x0005964C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981728, XrefRangeEnd = 981731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _SetWidget_b__7_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_4_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0005B488 File Offset: 0x00059688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981731, XrefRangeEnd = 981734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetWidget_b__7_5(float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetWidget_b__7_5_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0005B4C8 File Offset: 0x000596C8
		[CallerCount(0)]
		public unsafe float _SetupSettings_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetupSettings_b__9_0_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0005B504 File Offset: 0x00059704
		[CallerCount(0)]
		public unsafe float _SetupSettings_b__9_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetupSettings_b__9_1_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0005B540 File Offset: 0x00059740
		[CallerCount(0)]
		public unsafe float _SetupSettings_b__9_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerVector3.NativeMethodInfoPtr__SetupSettings_b__9_2_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0000A5F6 File Offset: 0x000087F6
		public DebugUIHandlerVector3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0005B57C File Offset: 0x0005977C
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0000A5FF File Offset: 0x000087FF
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0005B5AC File Offset: 0x000597AC
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0000A61E File Offset: 0x0000881E
		public unsafe UIFoldout valueToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_valueToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIFoldout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_valueToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0005B5DC File Offset: 0x000597DC
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0000A63D File Offset: 0x0000883D
		public unsafe DebugUIHandlerIndirectFloatField fieldX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_fieldX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerIndirectFloatField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_fieldX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0005B60C File Offset: 0x0005980C
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0000A65C File Offset: 0x0000885C
		public unsafe DebugUIHandlerIndirectFloatField fieldY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_fieldY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerIndirectFloatField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_fieldY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0005B63C File Offset: 0x0005983C
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0000A67B File Offset: 0x0000887B
		public unsafe DebugUIHandlerIndirectFloatField fieldZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_fieldZ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerIndirectFloatField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_fieldZ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0005B66C File Offset: 0x0005986C
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0000A69A File Offset: 0x0000889A
		public unsafe DebugUI.Vector3Field m_Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_m_Field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Vector3Field>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_m_Field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0005B69C File Offset: 0x0005989C
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0000A6B9 File Offset: 0x000088B9
		public unsafe DebugUIHandlerContainer m_Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_m_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerVector3.NativeFieldInfoPtr_m_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr_valueToggle;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_fieldX;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_fieldY;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_fieldZ;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_m_Field;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr_m_Container;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Private_Void_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_SetupSettings_Private_Void_DebugUIHandlerIndirectFloatField_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_OnAction_Public_Virtual_Void_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Virtual_DebugUIHandlerWidget_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr__SetWidget_b__7_0_Private_Single_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr__SetWidget_b__7_1_Private_Void_Single_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr__SetWidget_b__7_2_Private_Single_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr__SetWidget_b__7_3_Private_Void_Single_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr__SetWidget_b__7_4_Private_Single_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr__SetWidget_b__7_5_Private_Void_Single_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr__SetupSettings_b__9_0_Private_Single_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr__SetupSettings_b__9_1_Private_Single_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr__SetupSettings_b__9_2_Private_Single_0;
	}
}
