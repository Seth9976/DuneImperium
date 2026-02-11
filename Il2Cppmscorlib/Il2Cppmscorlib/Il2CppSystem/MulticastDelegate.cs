using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200015D RID: 349
	[Serializable]
	public class MulticastDelegate : Delegate
	{
		// Token: 0x060017A8 RID: 6056 RVA: 0x000967A8 File Offset: 0x000949A8
		// Note: this type is marked as 'beforefieldinit'.
		static MulticastDelegate()
		{
			Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MulticastDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr);
			MulticastDelegate.NativeFieldInfoPtr_delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, "delegates");
			MulticastDelegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667427);
			MulticastDelegate.NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_Final_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667428);
			MulticastDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667429);
			MulticastDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667430);
			MulticastDelegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667431);
			MulticastDelegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_Final_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667432);
			MulticastDelegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_Final_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667433);
			MulticastDelegate.NativeMethodInfoPtr_LastIndexOf_Private_Int32_Il2CppReferenceArray_1_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667434);
			MulticastDelegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_Final_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100667435);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000968A0 File Offset: 0x00094AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulticastDelegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00096904 File Offset: 0x00094B04
		[CallerCount(0)]
		public unsafe override Object DynamicInvokeImpl(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_Final_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00096954 File Offset: 0x00094B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347066, XrefRangeEnd = 1347072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x000969A4 File Offset: 0x00094BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x000969E0 File Offset: 0x00094BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347072, XrefRangeEnd = 1347076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethodImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulticastDelegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00096A2C File Offset: 0x00094C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347076, XrefRangeEnd = 1347081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Delegate> GetInvocationList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_Final_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr3) : null;
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00096A6C File Offset: 0x00094C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347081, XrefRangeEnd = 1347111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Delegate CombineImpl(Delegate follow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(follow);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_Final_Delegate_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00096ABC File Offset: 0x00094CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347111, XrefRangeEnd = 1347112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(Il2CppReferenceArray<Delegate> haystack, Il2CppReferenceArray<Delegate> needle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(haystack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(needle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_LastIndexOf_Private_Int32_Il2CppReferenceArray_1_Delegate_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00096B1C File Offset: 0x00094D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347112, XrefRangeEnd = 1347118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Delegate RemoveImpl(Delegate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_Final_Delegate_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0000781A File Offset: 0x00005A1A
		public MulticastDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00096B6C File Offset: 0x00094D6C
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00007823 File Offset: 0x00005A23
		public unsafe Il2CppReferenceArray<Delegate> delegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MulticastDelegate.NativeFieldInfoPtr_delegates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MulticastDelegate.NativeFieldInfoPtr_delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeFieldInfoPtr_delegates;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_Final_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_GetInvocationList_Public_Virtual_Final_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_CombineImpl_Protected_Virtual_Final_Delegate_Delegate_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Private_Int32_Il2CppReferenceArray_1_Delegate_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_Final_Delegate_Delegate_0;
	}
}
