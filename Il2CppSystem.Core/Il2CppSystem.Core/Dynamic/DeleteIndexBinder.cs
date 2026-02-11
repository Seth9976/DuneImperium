using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x02000118 RID: 280
	public class DeleteIndexBinder : DynamicMetaObjectBinder
	{
		// Token: 0x06001086 RID: 4230 RVA: 0x00056D04 File Offset: 0x00054F04
		// Note: this type is marked as 'beforefieldinit'.
		static DeleteIndexBinder()
		{
			Il2CppClassPointerStore<DeleteIndexBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "DeleteIndexBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeleteIndexBinder>.NativeClassPtr);
			DeleteIndexBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteIndexBinder>.NativeClassPtr, 100666390);
			DeleteIndexBinder.NativeMethodInfoPtr_FallbackDeleteIndex_Public_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteIndexBinder>.NativeClassPtr, 100666391);
			DeleteIndexBinder.NativeMethodInfoPtr_FallbackDeleteIndex_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeleteIndexBinder>.NativeClassPtr, 100666392);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00056D70 File Offset: 0x00054F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028280, XrefRangeEnd = 1028289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject Bind(DynamicMetaObject target, Il2CppReferenceArray<DynamicMetaObject> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteIndexBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00056DD4 File Offset: 0x00054FD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1027945, RefRangeEnd = 1027949, XrefRangeStart = 1027945, XrefRangeEnd = 1027949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, Il2CppReferenceArray<DynamicMetaObject> indexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeleteIndexBinder.NativeMethodInfoPtr_FallbackDeleteIndex_Public_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00056E38 File Offset: 0x00055038
		[CallerCount(0)]
		public unsafe virtual DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, Il2CppReferenceArray<DynamicMetaObject> indexes, DynamicMetaObject errorSuggestion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeleteIndexBinder.NativeMethodInfoPtr_FallbackDeleteIndex_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00007174 File Offset: 0x00005374
		public DeleteIndexBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_FallbackDeleteIndex_Public_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_FallbackDeleteIndex_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0;
	}
}
