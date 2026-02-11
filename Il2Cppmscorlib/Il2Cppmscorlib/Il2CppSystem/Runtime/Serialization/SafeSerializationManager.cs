using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000333 RID: 819
	[Serializable]
	public sealed class SafeSerializationManager : Object
	{
		// Token: 0x06003211 RID: 12817 RVA: 0x000FD76C File Offset: 0x000FB96C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSerializationManager()
		{
			Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SafeSerializationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr);
			SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_serializedStates");
			SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_savedSerializationInfo");
			SafeSerializationManager.NativeFieldInfoPtr_m_realObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_realObject");
			SafeSerializationManager.NativeFieldInfoPtr_m_realType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "m_realType");
			SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "SerializeObjectState");
			SafeSerializationManager.NativeFieldInfoPtr_RealTypeSerializationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, "RealTypeSerializationName");
			SafeSerializationManager.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671145);
			SafeSerializationManager.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671146);
			SafeSerializationManager.NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671147);
			SafeSerializationManager.NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671148);
			SafeSerializationManager.NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671149);
			SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671150);
			SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671151);
			SafeSerializationManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr, 100671152);
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000FD8B4 File Offset: 0x000FBAB4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000FD8F0 File Offset: 0x000FBAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385952, XrefRangeEnd = 1385986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationManager(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x000FD954 File Offset: 0x000FBB54
		public unsafe bool IsActive
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 480628, RefRangeEnd = 480631, XrefRangeStart = 480628, XrefRangeEnd = 480631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000FD990 File Offset: 0x000FBB90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1386017, RefRangeEnd = 1386018, XrefRangeStart = 1385986, XrefRangeEnd = 1386017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteSerialization(Object serializedObject, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000FD9FC File Offset: 0x000FBBFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1386043, RefRangeEnd = 1386044, XrefRangeStart = 1386018, XrefRangeEnd = 1386043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteDeserialization(Object deserializedObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deserializedObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x000FDA40 File Offset: 0x000FBC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386044, XrefRangeEnd = 1386053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000FDA9C File Offset: 0x000FBC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386053, XrefRangeEnd = 1386087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_Runtime_Serialization_IObjectReference_GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000FDAF4 File Offset: 0x000FBCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386087, XrefRangeEnd = 1386094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationManager.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x000114E9 File Offset: 0x0000F6E9
		public SafeSerializationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x000FDB3C File Offset: 0x000FBD3C
		// (set) Token: 0x0600321C RID: 12828 RVA: 0x000114F2 File Offset: 0x0000F6F2
		public unsafe IList<Object> m_serializedStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_serializedStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x000FDB6C File Offset: 0x000FBD6C
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x00011511 File Offset: 0x0000F711
		public unsafe SerializationInfo m_savedSerializationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_savedSerializationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x000FDB9C File Offset: 0x000FBD9C
		// (set) Token: 0x06003220 RID: 12832 RVA: 0x00011530 File Offset: 0x0000F730
		public unsafe Object m_realObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x000FDBCC File Offset: 0x000FBDCC
		// (set) Token: 0x06003222 RID: 12834 RVA: 0x0001154F File Offset: 0x0000F74F
		public unsafe RuntimeType m_realType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_m_realType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000FDBFC File Offset: 0x000FBDFC
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x0001156E File Offset: 0x0000F76E
		public unsafe EventHandler<SafeSerializationEventArgs> SerializeObjectState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SafeSerializationEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationManager.NativeFieldInfoPtr_SerializeObjectState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x000FDC2C File Offset: 0x000FBE2C
		// (set) Token: 0x06003226 RID: 12838 RVA: 0x0001158D File Offset: 0x0000F78D
		public unsafe static string RealTypeSerializationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeSerializationManager.NativeFieldInfoPtr_RealTypeSerializationName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeSerializationManager.NativeFieldInfoPtr_RealTypeSerializationName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedStates;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeFieldInfoPtr_m_savedSerializationInfo;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeFieldInfoPtr_m_realObject;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeFieldInfoPtr_m_realType;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeFieldInfoPtr_SerializeObjectState;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeFieldInfoPtr_RealTypeSerializationName;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Internal_get_Boolean_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSerialization_Internal_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeserialization_Internal_Void_Object_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002925 RID: 10533
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IObjectReference_GetRealObject_Private_Virtual_Final_New_Object_StreamingContext_0;

		// Token: 0x04002926 RID: 10534
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;
	}
}
