using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x0200011C RID: 284
	public class ExpandoClass : Object
	{
		// Token: 0x060010C1 RID: 4289 RVA: 0x00057F90 File Offset: 0x00056190
		// Note: this type is marked as 'beforefieldinit'.
		static ExpandoClass()
		{
			Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "ExpandoClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr);
			ExpandoClass.NativeFieldInfoPtr__keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, "_keys");
			ExpandoClass.NativeFieldInfoPtr__hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, "_hashCode");
			ExpandoClass.NativeFieldInfoPtr__transitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, "_transitions");
			ExpandoClass.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, "Empty");
			ExpandoClass.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, 100666428);
			ExpandoClass.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, 100666429);
			ExpandoClass.NativeMethodInfoPtr_FindNewClass_Internal_ExpandoClass_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, 100666430);
			ExpandoClass.NativeMethodInfoPtr_GetTransitionList_Private_List_1_WeakReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, 100666431);
			ExpandoClass.NativeMethodInfoPtr_GetValueIndex_Internal_Int32_String_Boolean_ExpandoObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, 100666432);
			ExpandoClass.NativeMethodInfoPtr_GetValueIndexCaseSensitive_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, 100666433);
			ExpandoClass.NativeMethodInfoPtr_GetValueIndexCaseInsensitive_Private_Int32_String_ExpandoObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, 100666434);
			ExpandoClass.NativeMethodInfoPtr_get_Keys_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr, 100666435);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000580B0 File Offset: 0x000562B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028592, XrefRangeEnd = 1028597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpandoClass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoClass.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x000580EC File Offset: 0x000562EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028597, XrefRangeEnd = 1028599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpandoClass(Il2CppStringArray keys, int hashCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandoClass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoClass.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00058148 File Offset: 0x00056348
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1028654, RefRangeEnd = 1028657, XrefRangeStart = 1028599, XrefRangeEnd = 1028654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpandoClass FindNewClass(string newKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoClass.NativeMethodInfoPtr_FindNewClass_Internal_ExpandoClass_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpandoClass>(intPtr3) : null;
			}
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00058198 File Offset: 0x00056398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028657, XrefRangeEnd = 1028676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WeakReference> GetTransitionList(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoClass.NativeMethodInfoPtr_GetTransitionList_Private_List_1_WeakReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WeakReference>>(intPtr3) : null;
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x000581E4 File Offset: 0x000563E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1028689, RefRangeEnd = 1028693, XrefRangeStart = 1028676, XrefRangeEnd = 1028689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoClass.NativeMethodInfoPtr_GetValueIndex_Internal_Int32_String_Boolean_ExpandoObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00058254 File Offset: 0x00056454
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1028695, RefRangeEnd = 1028706, XrefRangeStart = 1028693, XrefRangeEnd = 1028695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetValueIndexCaseSensitive(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoClass.NativeMethodInfoPtr_GetValueIndexCaseSensitive_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000582A4 File Offset: 0x000564A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1028710, RefRangeEnd = 1028714, XrefRangeStart = 1028706, XrefRangeEnd = 1028710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetValueIndexCaseInsensitive(string name, ExpandoObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoClass.NativeMethodInfoPtr_GetValueIndexCaseInsensitive_Private_Int32_String_ExpandoObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00058304 File Offset: 0x00056504
		public unsafe Il2CppStringArray Keys
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandoClass.NativeMethodInfoPtr_get_Keys_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00007253 File Offset: 0x00005453
		public ExpandoClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x00058344 File Offset: 0x00056544
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x0000725C File Offset: 0x0000545C
		public unsafe Il2CppStringArray _keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoClass.NativeFieldInfoPtr__keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoClass.NativeFieldInfoPtr__keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x00058374 File Offset: 0x00056574
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0000727B File Offset: 0x0000547B
		public unsafe int _hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoClass.NativeFieldInfoPtr__hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoClass.NativeFieldInfoPtr__hashCode)) = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0005839C File Offset: 0x0005659C
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00007296 File Offset: 0x00005496
		public unsafe Dictionary<int, List<WeakReference>> _transitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoClass.NativeFieldInfoPtr__transitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<WeakReference>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandoClass.NativeFieldInfoPtr__transitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x000583CC File Offset: 0x000565CC
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x000072B5 File Offset: 0x000054B5
		public unsafe static ExpandoClass Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpandoClass.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandoClass>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpandoClass.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr__keys;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr__hashCode;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr__transitions;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Int32_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_FindNewClass_Internal_ExpandoClass_String_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_GetTransitionList_Private_List_1_WeakReference_Int32_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_GetValueIndex_Internal_Int32_String_Boolean_ExpandoObject_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_GetValueIndexCaseSensitive_Internal_Int32_String_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_GetValueIndexCaseInsensitive_Private_Int32_String_ExpandoObject_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Internal_get_Il2CppStringArray_0;
	}
}
