using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000331 RID: 817
	public sealed class SafeSerializationEventArgs : EventArgs
	{
		// Token: 0x06003205 RID: 12805 RVA: 0x000FD55C File Offset: 0x000FB75C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeSerializationEventArgs()
		{
			Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SafeSerializationEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr);
			SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, "m_streamingContext");
			SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, "m_serializedStates");
			SafeSerializationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, 100671141);
			SafeSerializationEventArgs.NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, 100671142);
			SafeSerializationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr, 100671143);
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x000FD5F0 File Offset: 0x000FB7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385937, XrefRangeEnd = 1385949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationEventArgs(StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x000FD640 File Offset: 0x000FB840
		public unsafe IList<Object> SerializedStates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationEventArgs.NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x000FD680 File Offset: 0x000FB880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385949, XrefRangeEnd = 1385952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeSerializationEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeSerializationEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeSerializationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x0001145B File Offset: 0x0000F65B
		public SafeSerializationEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x000FD6BC File Offset: 0x000FB8BC
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x00011464 File Offset: 0x0000F664
		public StreamingContext m_streamingContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_streamingContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x000FD6EC File Offset: 0x000FB8EC
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x00011492 File Offset: 0x0000F692
		public unsafe List<Object> m_serializedStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeSerializationEventArgs.NativeFieldInfoPtr_m_serializedStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeFieldInfoPtr_m_streamingContext;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeFieldInfoPtr_m_serializedStates;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StreamingContext_0;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializedStates_Internal_get_IList_1_Object_0;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
