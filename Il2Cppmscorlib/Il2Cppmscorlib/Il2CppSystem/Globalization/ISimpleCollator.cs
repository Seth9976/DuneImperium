using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200048D RID: 1165
	public class ISimpleCollator : Il2CppObjectBase
	{
		// Token: 0x060047B7 RID: 18359 RVA: 0x0014ECF8 File Offset: 0x0014CEF8
		// Note: this type is marked as 'beforefieldinit'.
		static ISimpleCollator()
		{
			Il2CppClassPointerStore<ISimpleCollator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "ISimpleCollator");
			ISimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_Abstract_Virtual_New_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleCollator>.NativeClassPtr, 100673821);
			ISimpleCollator.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleCollator>.NativeClassPtr, 100673822);
			ISimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Abstract_Virtual_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleCollator>.NativeClassPtr, 100673823);
			ISimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Abstract_Virtual_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleCollator>.NativeClassPtr, 100673824);
			ISimpleCollator.NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleCollator>.NativeClassPtr, 100673825);
			ISimpleCollator.NativeMethodInfoPtr_LastIndexOf_Public_Abstract_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISimpleCollator>.NativeClassPtr, 100673826);
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x0014ED98 File Offset: 0x0014CF98
		[CallerCount(0)]
		public unsafe virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleCollator.NativeMethodInfoPtr_GetSortKey_Public_Abstract_Virtual_New_SortKey_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x0014EE04 File Offset: 0x0014D004
		[CallerCount(0)]
		public unsafe virtual int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleCollator.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x0014EEB8 File Offset: 0x0014D0B8
		[CallerCount(0)]
		public unsafe virtual bool IsPrefix(string src, string target, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleCollator.NativeMethodInfoPtr_IsPrefix_Public_Abstract_Virtual_New_Boolean_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x0014EF30 File Offset: 0x0014D130
		[CallerCount(0)]
		public unsafe virtual bool IsSuffix(string src, string target, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleCollator.NativeMethodInfoPtr_IsSuffix_Public_Abstract_Virtual_New_Boolean_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x0014EFA8 File Offset: 0x0014D1A8
		[CallerCount(0)]
		public unsafe virtual int IndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleCollator.NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x0014F03C File Offset: 0x0014D23C
		[CallerCount(0)]
		public unsafe virtual int LastIndexOf(string s, string target, int start, int length, CompareOptions opt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISimpleCollator.NativeMethodInfoPtr_LastIndexOf_Public_Abstract_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x0001A072 File Offset: 0x00018272
		public ISimpleCollator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B1B RID: 15131
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_Abstract_Virtual_New_SortKey_String_CompareOptions_0;

		// Token: 0x04003B1C RID: 15132
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04003B1D RID: 15133
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Abstract_Virtual_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x04003B1E RID: 15134
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Abstract_Virtual_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x04003B1F RID: 15135
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x04003B20 RID: 15136
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Abstract_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0;
	}
}
