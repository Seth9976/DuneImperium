using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	public sealed class SqlNullValueException : SqlTypeException
	{
		// Token: 0x06001095 RID: 4245 RVA: 0x0004EF0C File Offset: 0x0004D10C
		// Note: this type is marked as 'beforefieldinit'.
		static SqlNullValueException()
		{
			Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlNullValueException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr);
			SqlNullValueException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr, 100665960);
			SqlNullValueException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr, 100665961);
			SqlNullValueException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr, 100665962);
			SqlNullValueException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr, 100665963);
			SqlNullValueException.NativeMethodInfoPtr_SqlNullValueExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr, 100665964);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0004EFA0 File Offset: 0x0004D1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920129, XrefRangeEnd = 920131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlNullValueException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlNullValueException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0004EFDC File Offset: 0x0004D1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920131, XrefRangeEnd = 920132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlNullValueException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlNullValueException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0004F028 File Offset: 0x0004D228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920132, XrefRangeEnd = 920133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlNullValueException(string message, Exception e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlNullValueException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0004F088 File Offset: 0x0004D288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920133, XrefRangeEnd = 920141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlNullValueException(SerializationInfo si, StreamingContext sc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SqlNullValueException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlNullValueException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0004F0EC File Offset: 0x0004D2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920141, XrefRangeEnd = 920148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlNullValueException.NativeMethodInfoPtr_SqlNullValueExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr3) : null;
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00006EFF File Offset: 0x000050FF
		public SqlNullValueException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_SqlNullValueExceptionSerialization_Private_Static_SerializationInfo_SerializationInfo_StreamingContext_0;
	}
}
