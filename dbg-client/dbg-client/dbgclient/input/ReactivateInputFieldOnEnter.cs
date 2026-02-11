using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace dbgclient.input
{
	// Token: 0x020000B0 RID: 176
	public class ReactivateInputFieldOnEnter : MonoBehaviour
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x00033D3C File Offset: 0x00031F3C
		// Note: this type is marked as 'beforefieldinit'.
		static ReactivateInputFieldOnEnter()
		{
			Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.input", "ReactivateInputFieldOnEnter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr);
			ReactivateInputFieldOnEnter.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, "input");
			ReactivateInputFieldOnEnter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, 100664383);
			ReactivateInputFieldOnEnter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, 100664384);
			ReactivateInputFieldOnEnter.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, 100664385);
			ReactivateInputFieldOnEnter.NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, 100664386);
			ReactivateInputFieldOnEnter.NativeMethodInfoPtr_removeListeners_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, 100664387);
			ReactivateInputFieldOnEnter.NativeMethodInfoPtr_getInputField_Protected_Static_T_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, 100664388);
			ReactivateInputFieldOnEnter.NativeMethodInfoPtr_handleSubmit_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, 100664389);
			ReactivateInputFieldOnEnter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr, 100664390);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00033E20 File Offset: 0x00032020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503986, XrefRangeEnd = 503990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReactivateInputFieldOnEnter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00033E54 File Offset: 0x00032054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503990, XrefRangeEnd = 503994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReactivateInputFieldOnEnter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00033E88 File Offset: 0x00032088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503994, XrefRangeEnd = 503998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReactivateInputFieldOnEnter.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00033EBC File Offset: 0x000320BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 503998, XrefRangeEnd = 504009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void addListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReactivateInputFieldOnEnter.NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00033EF8 File Offset: 0x000320F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504009, XrefRangeEnd = 504020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void removeListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReactivateInputFieldOnEnter.NativeMethodInfoPtr_removeListeners_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00033F34 File Offset: 0x00032134
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 504022, RefRangeEnd = 504028, XrefRangeStart = 504020, XrefRangeEnd = 504022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T getInputField<T>(Selectable input) where T : Selectable
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReactivateInputFieldOnEnter.MethodInfoStoreGeneric_getInputField_Protected_Static_T_Selectable_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00033F74 File Offset: 0x00032174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504028, XrefRangeEnd = 504034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void handleSubmit(string finalText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(finalText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReactivateInputFieldOnEnter.NativeMethodInfoPtr_handleSubmit_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00033FC4 File Offset: 0x000321C4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReactivateInputFieldOnEnter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReactivateInputFieldOnEnter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00005428 File Offset: 0x00003628
		public ReactivateInputFieldOnEnter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00034000 File Offset: 0x00032200
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00005431 File Offset: 0x00003631
		public unsafe Selectable input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReactivateInputFieldOnEnter.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReactivateInputFieldOnEnter.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_removeListeners_Protected_Virtual_New_Void_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_getInputField_Protected_Static_T_Selectable_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_handleSubmit_Protected_Virtual_New_Void_String_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031B RID: 795
		private sealed class MethodInfoStoreGeneric_getInputField_Protected_Static_T_Selectable_0<T>
		{
			// Token: 0x0400178E RID: 6030
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReactivateInputFieldOnEnter.NativeMethodInfoPtr_getInputField_Protected_Static_T_Selectable_0, Il2CppClassPointerStore<ReactivateInputFieldOnEnter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
