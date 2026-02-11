using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace core.ui
{
	// Token: 0x02000006 RID: 6
	public class SubmitOnEnter : MonoBehaviour
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002EB8 File Offset: 0x000010B8
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitOnEnter()
		{
			Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "core.ui", "SubmitOnEnter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr);
			SubmitOnEnter.NativeFieldInfoPtr_SubmitAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, "SubmitAction");
			SubmitOnEnter.NativeFieldInfoPtr_clearText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, "clearText");
			SubmitOnEnter.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, "input");
			SubmitOnEnter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663303);
			SubmitOnEnter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663304);
			SubmitOnEnter.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663305);
			SubmitOnEnter.NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663306);
			SubmitOnEnter.NativeMethodInfoPtr_removeListeners_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663307);
			SubmitOnEnter.NativeMethodInfoPtr_clearInputText_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663308);
			SubmitOnEnter.NativeMethodInfoPtr_getInputField_Protected_T_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663309);
			SubmitOnEnter.NativeMethodInfoPtr_handleSubmit_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663310);
			SubmitOnEnter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002FD8 File Offset: 0x000011D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253400, XrefRangeEnd = 1253404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitOnEnter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000300C File Offset: 0x0000120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253404, XrefRangeEnd = 1253408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitOnEnter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003040 File Offset: 0x00001240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253408, XrefRangeEnd = 1253412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitOnEnter.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003074 File Offset: 0x00001274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253412, XrefRangeEnd = 1253425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void addListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubmitOnEnter.NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000030B0 File Offset: 0x000012B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253425, XrefRangeEnd = 1253430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void removeListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubmitOnEnter.NativeMethodInfoPtr_removeListeners_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000030EC File Offset: 0x000012EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253430, XrefRangeEnd = 1253437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void clearInputText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubmitOnEnter.NativeMethodInfoPtr_clearInputText_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003128 File Offset: 0x00001328
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1253441, RefRangeEnd = 1253447, XrefRangeStart = 1253437, XrefRangeEnd = 1253441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T getInputField<T>(Selectable input) where T : Selectable
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitOnEnter.MethodInfoStoreGeneric_getInputField_Protected_T_Selectable_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003174 File Offset: 0x00001374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253447, XrefRangeEnd = 1253458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleSubmit(string finalText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(finalText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitOnEnter.NativeMethodInfoPtr_handleSubmit_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000031B8 File Offset: 0x000013B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubmitOnEnter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitOnEnter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020E7 File Offset: 0x000002E7
		public SubmitOnEnter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000031F4 File Offset: 0x000013F4
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe UnityEvent SubmitAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitOnEnter.NativeFieldInfoPtr_SubmitAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitOnEnter.NativeFieldInfoPtr_SubmitAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe bool clearText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitOnEnter.NativeFieldInfoPtr_clearText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitOnEnter.NativeFieldInfoPtr_clearText)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000324C File Offset: 0x0000144C
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000212A File Offset: 0x0000032A
		public unsafe Selectable input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitOnEnter.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmitOnEnter.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_SubmitAction;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_clearText;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_addListener_Protected_Virtual_New_Void_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_removeListeners_Protected_Virtual_New_Void_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_clearInputText_Protected_Virtual_New_Void_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_getInputField_Protected_T_Selectable_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_handleSubmit_Protected_Void_String_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_getInputField_Protected_T_Selectable_0<T>
		{
			// Token: 0x040000C5 RID: 197
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SubmitOnEnter.NativeMethodInfoPtr_getInputField_Protected_T_Selectable_0, Il2CppClassPointerStore<SubmitOnEnter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
