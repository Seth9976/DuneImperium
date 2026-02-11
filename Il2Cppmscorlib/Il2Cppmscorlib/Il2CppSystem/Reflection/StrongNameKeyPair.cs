using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200044F RID: 1103
	[Serializable]
	public class StrongNameKeyPair : Object
	{
		// Token: 0x06004073 RID: 16499 RVA: 0x00134B74 File Offset: 0x00132D74
		// Note: this type is marked as 'beforefieldinit'.
		static StrongNameKeyPair()
		{
			Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "StrongNameKeyPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr);
			StrongNameKeyPair.NativeFieldInfoPtr__publicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_publicKey");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairContainer");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairExported");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairArray");
			StrongNameKeyPair.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100673020);
			StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100673021);
			StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100673022);
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x00134C30 File Offset: 0x00132E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402203, XrefRangeEnd = 1402243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrongNameKeyPair(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x00134C94 File Offset: 0x00132E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1402243, XrefRangeEnd = 1402263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x00134CF0 File Offset: 0x00132EF0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x0001770B File Offset: 0x0001590B
		public StrongNameKeyPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x00134D34 File Offset: 0x00132F34
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x00017714 File Offset: 0x00015914
		public unsafe Il2CppStructArray<byte> _publicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__publicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__publicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x00134D64 File Offset: 0x00132F64
		// (set) Token: 0x0600407B RID: 16507 RVA: 0x00017733 File Offset: 0x00015933
		public unsafe string _keyPairContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x00134D8C File Offset: 0x00132F8C
		// (set) Token: 0x0600407D RID: 16509 RVA: 0x00017752 File Offset: 0x00015952
		public unsafe bool _keyPairExported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported)) = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x00134DB4 File Offset: 0x00132FB4
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x0001776D File Offset: 0x0001596D
		public unsafe Il2CppStructArray<byte> _keyPairArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400350D RID: 13581
		private static readonly IntPtr NativeFieldInfoPtr__publicKey;

		// Token: 0x0400350E RID: 13582
		private static readonly IntPtr NativeFieldInfoPtr__keyPairContainer;

		// Token: 0x0400350F RID: 13583
		private static readonly IntPtr NativeFieldInfoPtr__keyPairExported;

		// Token: 0x04003510 RID: 13584
		private static readonly IntPtr NativeFieldInfoPtr__keyPairArray;

		// Token: 0x04003511 RID: 13585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003512 RID: 13586
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003513 RID: 13587
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;
	}
}
