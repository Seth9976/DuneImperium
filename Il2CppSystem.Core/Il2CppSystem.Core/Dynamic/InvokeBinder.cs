using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x02000121 RID: 289
	public class InvokeBinder : DynamicMetaObjectBinder
	{
		// Token: 0x0600111D RID: 4381 RVA: 0x000598B0 File Offset: 0x00057AB0
		// Note: this type is marked as 'beforefieldinit'.
		static InvokeBinder()
		{
			Il2CppClassPointerStore<InvokeBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "InvokeBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokeBinder>.NativeClassPtr);
			InvokeBinder.NativeMethodInfoPtr_FallbackInvoke_Public_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeBinder>.NativeClassPtr, 100666551);
			InvokeBinder.NativeMethodInfoPtr_FallbackInvoke_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeBinder>.NativeClassPtr, 100666552);
			InvokeBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokeBinder>.NativeClassPtr, 100666553);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0005991C File Offset: 0x00057B1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1027945, RefRangeEnd = 1027949, XrefRangeStart = 1027945, XrefRangeEnd = 1027949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject FallbackInvoke(DynamicMetaObject target, Il2CppReferenceArray<DynamicMetaObject> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeBinder.NativeMethodInfoPtr_FallbackInvoke_Public_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00059980 File Offset: 0x00057B80
		[CallerCount(0)]
		public unsafe virtual DynamicMetaObject FallbackInvoke(DynamicMetaObject target, Il2CppReferenceArray<DynamicMetaObject> args, DynamicMetaObject errorSuggestion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokeBinder.NativeMethodInfoPtr_FallbackInvoke_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00059A00 File Offset: 0x00057C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029508, XrefRangeEnd = 1029520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokeBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00007438 File Offset: 0x00005638
		public InvokeBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_FallbackInvoke_Public_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_FallbackInvoke_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0;
	}
}
