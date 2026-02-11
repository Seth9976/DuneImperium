using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033B RID: 827
	[Serializable]
	public sealed class StreamingContext : ValueType
	{
		// Token: 0x06003294 RID: 12948 RVA: 0x000FF798 File Offset: 0x000FD998
		// Note: this type is marked as 'beforefieldinit'.
		static StreamingContext()
		{
			Il2CppClassPointerStore<StreamingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "StreamingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr);
			StreamingContext.NativeFieldInfoPtr_m_additionalContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, "m_additionalContext");
			StreamingContext.NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, "m_state");
			StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671212);
			StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671213);
			StreamingContext.NativeMethodInfoPtr_get_Context_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671214);
			StreamingContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671215);
			StreamingContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671216);
			StreamingContext.NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, 100671217);
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000FF868 File Offset: 0x000FDA68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387072, RefRangeEnd = 1387073, XrefRangeStart = 1387071, XrefRangeEnd = 1387072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamingContext(StreamingContextStates state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000FF8B4 File Offset: 0x000FDAB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387074, RefRangeEnd = 1387077, XrefRangeStart = 1387073, XrefRangeEnd = 1387074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamingContext(StreamingContextStates state, Object additional)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additional);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x000FF914 File Offset: 0x000FDB14
		public unsafe Object Context
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_get_Context_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000FF958 File Offset: 0x000FDB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387077, XrefRangeEnd = 1387082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000FF9AC File Offset: 0x000FDBAC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600329A RID: 12954 RVA: 0x000FF9F0 File Offset: 0x000FDBF0
		public unsafe StreamingContextStates State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamingContext.NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000118B1 File Offset: 0x0000FAB1
		public StreamingContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000118BA File Offset: 0x0000FABA
		public StreamingContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x000FFA34 File Offset: 0x000FDC34
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x000118CC File Offset: 0x0000FACC
		public unsafe Object m_additionalContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_additionalContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_additionalContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x000FFA64 File Offset: 0x000FDC64
		// (set) Token: 0x060032A0 RID: 12960 RVA: 0x000118EB File Offset: 0x0000FAEB
		public unsafe StreamingContextStates m_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamingContext.NativeFieldInfoPtr_m_state)) = value;
			}
		}

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeFieldInfoPtr_m_additionalContext;

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeFieldInfoPtr_m_state;

		// Token: 0x04002976 RID: 10614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_0;

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContextStates_Object_0;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_Object_0;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_StreamingContextStates_0;
	}
}
