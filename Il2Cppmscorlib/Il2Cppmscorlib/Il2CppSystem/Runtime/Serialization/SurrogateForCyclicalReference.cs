using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000327 RID: 807
	public sealed class SurrogateForCyclicalReference : Object
	{
		// Token: 0x06003132 RID: 12594 RVA: 0x000FA164 File Offset: 0x000F8364
		// Note: this type is marked as 'beforefieldinit'.
		static SurrogateForCyclicalReference()
		{
			Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SurrogateForCyclicalReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr);
			SurrogateForCyclicalReference.NativeFieldInfoPtr_innerSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr, "innerSurrogate");
			SurrogateForCyclicalReference.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr, 100671037);
			SurrogateForCyclicalReference.NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurrogateForCyclicalReference>.NativeClassPtr, 100671038);
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x000FA1D0 File Offset: 0x000F83D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385218, XrefRangeEnd = 1385221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurrogateForCyclicalReference.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x000FA23C File Offset: 0x000F843C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385221, XrefRangeEnd = 1385224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object SetObjectData(Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurrogateForCyclicalReference.NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00010EF7 File Offset: 0x0000F0F7
		public SurrogateForCyclicalReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x000FA2C8 File Offset: 0x000F84C8
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x00010F00 File Offset: 0x0000F100
		public unsafe ISerializationSurrogate innerSurrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurrogateForCyclicalReference.NativeFieldInfoPtr_innerSurrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurrogateForCyclicalReference.NativeFieldInfoPtr_innerSurrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeFieldInfoPtr_innerSurrogate;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectData_Public_Virtual_Final_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0;
	}
}
