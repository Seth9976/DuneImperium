using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000071 RID: 113
	[Serializable]
	public class ArgumentException : SystemException
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x000421E4 File Offset: 0x000403E4
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentException()
		{
			Il2CppClassPointerStore<ArgumentException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgumentException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr);
			ArgumentException.NativeFieldInfoPtr__paramName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, "_paramName");
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664340);
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664341);
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664342);
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664343);
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664344);
			ArgumentException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664345);
			ArgumentException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664346);
			ArgumentException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664347);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000422C8 File Offset: 0x000404C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1297282, RefRangeEnd = 1297283, XrefRangeStart = 1297279, XrefRangeEnd = 1297282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00042304 File Offset: 0x00040504
		[CallerCount(369)]
		[CachedScanResults(RefRangeStart = 1297284, RefRangeEnd = 1297653, XrefRangeStart = 1297283, XrefRangeEnd = 1297284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00042350 File Offset: 0x00040550
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1297654, RefRangeEnd = 1297659, XrefRangeStart = 1297653, XrefRangeEnd = 1297654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000423B0 File Offset: 0x000405B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1297659, XrefRangeEnd = 1297661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(string message, string paramName, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00042420 File Offset: 0x00040620
		[CallerCount(173)]
		[CachedScanResults(RefRangeStart = 1297663, RefRangeEnd = 1297836, XrefRangeStart = 1297661, XrefRangeEnd = 1297663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(string message, string paramName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00042480 File Offset: 0x00040680
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1297842, RefRangeEnd = 1297847, XrefRangeStart = 1297836, XrefRangeEnd = 1297842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000424E4 File Offset: 0x000406E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1297857, RefRangeEnd = 1297858, XrefRangeStart = 1297847, XrefRangeEnd = 1297857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00042548 File Offset: 0x00040748
		public unsafe override string Message
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1297861, RefRangeEnd = 1297862, XrefRangeStart = 1297858, XrefRangeEnd = 1297861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00003F29 File Offset: 0x00002129
		public ArgumentException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0004258C File Offset: 0x0004078C
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00003F32 File Offset: 0x00002132
		public unsafe string _paramName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentException.NativeFieldInfoPtr__paramName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentException.NativeFieldInfoPtr__paramName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr__paramName;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Exception_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
