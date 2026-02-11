using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000EA RID: 234
	[Serializable]
	public sealed class OrdinalIgnoreCaseComparer : OrdinalComparer
	{
		// Token: 0x06000F28 RID: 3880 RVA: 0x0006CB3C File Offset: 0x0006AD3C
		// Note: this type is marked as 'beforefieldinit'.
		static OrdinalIgnoreCaseComparer()
		{
			Il2CppClassPointerStore<OrdinalIgnoreCaseComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OrdinalIgnoreCaseComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrdinalIgnoreCaseComparer>.NativeClassPtr);
			OrdinalIgnoreCaseComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalIgnoreCaseComparer>.NativeClassPtr, 100665946);
			OrdinalIgnoreCaseComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalIgnoreCaseComparer>.NativeClassPtr, 100665947);
			OrdinalIgnoreCaseComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalIgnoreCaseComparer>.NativeClassPtr, 100665948);
			OrdinalIgnoreCaseComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalIgnoreCaseComparer>.NativeClassPtr, 100665949);
			OrdinalIgnoreCaseComparer.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalIgnoreCaseComparer>.NativeClassPtr, 100665950);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0006CBD0 File Offset: 0x0006ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320857, XrefRangeEnd = 1320861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrdinalIgnoreCaseComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrdinalIgnoreCaseComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalIgnoreCaseComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0006CC0C File Offset: 0x0006AE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320861, XrefRangeEnd = 1320862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(string x, string y)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalIgnoreCaseComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0006CC6C File Offset: 0x0006AE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320862, XrefRangeEnd = 1320863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalIgnoreCaseComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0006CCCC File Offset: 0x0006AECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320863, XrefRangeEnd = 1320868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalIgnoreCaseComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0006CD1C File Offset: 0x0006AF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320868, XrefRangeEnd = 1320884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrdinalIgnoreCaseComparer.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00005A34 File Offset: 0x00003C34
		public OrdinalIgnoreCaseComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;
	}
}
