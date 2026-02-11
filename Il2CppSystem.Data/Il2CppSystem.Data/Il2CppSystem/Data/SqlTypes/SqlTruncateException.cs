using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x020000A0 RID: 160
	[Serializable]
	public sealed class SqlTruncateException : SqlTypeException
	{
		// Token: 0x0600109C RID: 4252 RVA: 0x0004F148 File Offset: 0x0004D348
		// Note: this type is marked as 'beforefieldinit'.
		static SqlTruncateException()
		{
			Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlTruncateException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr);
			SqlTruncateException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr, 100665965);
			SqlTruncateException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr, 100665966);
			SqlTruncateException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr, 100665967);
			SqlTruncateException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr, 100665968);
			SqlTruncateException.NativeMethodInfoPtr_SqlTruncateExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr, 100665969);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0004F1DC File Offset: 0x0004D3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920148, XrefRangeEnd = 920150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlTruncateException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTruncateException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0004F218 File Offset: 0x0004D418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920150, XrefRangeEnd = 920151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlTruncateException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTruncateException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0004F264 File Offset: 0x0004D464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920151, XrefRangeEnd = 920152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlTruncateException(string message, Exception e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTruncateException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0004F2C4 File Offset: 0x0004D4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920152, XrefRangeEnd = 920160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlTruncateException(SerializationInfo si, StreamingContext sc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlTruncateException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTruncateException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0004F328 File Offset: 0x0004D528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920160, XrefRangeEnd = 920167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlTruncateException.NativeMethodInfoPtr_SqlTruncateExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr3) : null;
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00006F08 File Offset: 0x00005108
		public SqlTruncateException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_SqlTruncateExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0;
	}
}
