using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200050F RID: 1295
	[Serializable]
	public sealed class InternalStringComparer : EqualityComparer<string>
	{
		// Token: 0x06004F67 RID: 20327 RVA: 0x00171C2C File Offset: 0x0016FE2C
		// Note: this type is marked as 'beforefieldinit'.
		static InternalStringComparer()
		{
			Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "InternalStringComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr);
			InternalStringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr, 100675277);
			InternalStringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr, 100675278);
			InternalStringComparer.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStringArray_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr, 100675279);
			InternalStringComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr, 100675280);
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x00171CAC File Offset: 0x0016FEAC
		[CallerCount(0)]
		public unsafe override int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalStringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x00171CFC File Offset: 0x0016FEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426486, XrefRangeEnd = 1426487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalStringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x00171D5C File Offset: 0x0016FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426487, XrefRangeEnd = 1426488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int IndexOf(Il2CppStringArray array, string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalStringComparer.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStringArray_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x00171DD8 File Offset: 0x0016FFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426488, XrefRangeEnd = 1426491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalStringComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalStringComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalStringComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x0001C802 File Offset: 0x0001AA02
		public InternalStringComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040040C5 RID: 16581
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0;

		// Token: 0x040040C6 RID: 16582
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0;

		// Token: 0x040040C7 RID: 16583
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStringArray_String_Int32_Int32_0;

		// Token: 0x040040C8 RID: 16584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
