using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dbgclient.matchHistory
{
	// Token: 0x0200002A RID: 42
	public sealed class OfflineMessage : ValueType
	{
		// Token: 0x06000175 RID: 373 RVA: 0x000151D8 File Offset: 0x000133D8
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineMessage()
		{
			Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dbgclient.matchHistory", "OfflineMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr);
			OfflineMessage.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, "URL");
			OfflineMessage.NativeFieldInfoPtr_UseToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, "UseToken");
			OfflineMessage.NativeFieldInfoPtr_SerializedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, "SerializedObject");
			OfflineMessage.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, 100663569);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00015258 File Offset: 0x00013458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983764, XrefRangeEnd = 983766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineMessage(string url, bool useToken, string serializedObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useToken;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(serializedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessage.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002AD5 File Offset: 0x00000CD5
		public OfflineMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002ADE File Offset: 0x00000CDE
		public OfflineMessage()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr))
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000152C8 File Offset: 0x000134C8
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public unsafe string URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_URL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_URL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000152F0 File Offset: 0x000134F0
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002B0F File Offset: 0x00000D0F
		public unsafe bool UseToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_UseToken);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_UseToken)) = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00015318 File Offset: 0x00013518
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002B2A File Offset: 0x00000D2A
		public unsafe string SerializedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_SerializedObject);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_SerializedObject), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_UseToken;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_SerializedObject;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_String_0;
	}
}
