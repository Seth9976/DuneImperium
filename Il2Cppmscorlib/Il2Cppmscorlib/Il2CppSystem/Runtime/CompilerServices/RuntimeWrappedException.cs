using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C2 RID: 962
	[Serializable]
	public sealed class RuntimeWrappedException : Exception
	{
		// Token: 0x0600393C RID: 14652 RVA: 0x001153F8 File Offset: 0x001135F8
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeWrappedException()
		{
			Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeWrappedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr);
			RuntimeWrappedException.NativeFieldInfoPtr__wrappedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, "_wrappedException");
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100671836);
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100671837);
			RuntimeWrappedException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100671838);
			RuntimeWrappedException.NativeMethodInfoPtr_get_WrappedException_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100671839);
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100671840);
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x001154A0 File Offset: 0x001136A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1392958, RefRangeEnd = 1392959, XrefRangeStart = 1392951, XrefRangeEnd = 1392958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException(Object thrownObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thrownObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x001154EC File Offset: 0x001136EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392959, XrefRangeEnd = 1392974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00115550 File Offset: 0x00113750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392974, XrefRangeEnd = 1392984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06003940 RID: 14656 RVA: 0x001155AC File Offset: 0x001137AC
		public unsafe Object WrappedException
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr_get_WrappedException_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x001155EC File Offset: 0x001137EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392984, XrefRangeEnd = 1392987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x000152F6 File Offset: 0x000134F6
		public RuntimeWrappedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x00115628 File Offset: 0x00113828
		// (set) Token: 0x06003944 RID: 14660 RVA: 0x000152FF File Offset: 0x000134FF
		public unsafe Object _wrappedException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeWrappedException.NativeFieldInfoPtr__wrappedException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeWrappedException.NativeFieldInfoPtr__wrappedException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeFieldInfoPtr__wrappedException;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeMethodInfoPtr_get_WrappedException_Public_get_Object_0;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
