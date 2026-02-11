using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200009E RID: 158
	[Serializable]
	public class SqlTypeException : SystemException
	{
		// Token: 0x0600108E RID: 4238 RVA: 0x0004ECD0 File Offset: 0x0004CED0
		// Note: this type is marked as 'beforefieldinit'.
		static SqlTypeException()
		{
			Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlTypeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr);
			SqlTypeException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr, 100665955);
			SqlTypeException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr, 100665956);
			SqlTypeException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr, 100665957);
			SqlTypeException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr, 100665958);
			SqlTypeException.NativeMethodInfoPtr_SqlTypeExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr, 100665959);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0004ED64 File Offset: 0x0004CF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920107, XrefRangeEnd = 920110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlTypeException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTypeException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0004EDA0 File Offset: 0x0004CFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920110, XrefRangeEnd = 920111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlTypeException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTypeException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0004EDEC File Offset: 0x0004CFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920111, XrefRangeEnd = 920112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlTypeException(string message, Exception e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTypeException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0004EE4C File Offset: 0x0004D04C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 920120, RefRangeEnd = 920122, XrefRangeStart = 920112, XrefRangeEnd = 920120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlTypeException(SerializationInfo si, StreamingContext sc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlTypeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTypeException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0004EEB0 File Offset: 0x0004D0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920122, XrefRangeEnd = 920129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTypeException.NativeMethodInfoPtr_SqlTypeExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr3) : null;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00006EF6 File Offset: 0x000050F6
		public SqlTypeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_SqlTypeExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0;
	}
}
