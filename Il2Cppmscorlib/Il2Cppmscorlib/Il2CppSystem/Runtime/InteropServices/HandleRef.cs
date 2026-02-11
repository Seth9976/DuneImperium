using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200037A RID: 890
	public sealed class HandleRef : ValueType
	{
		// Token: 0x06003767 RID: 14183 RVA: 0x0010F3B0 File Offset: 0x0010D5B0
		// Note: this type is marked as 'beforefieldinit'.
		static HandleRef()
		{
			Il2CppClassPointerStore<HandleRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "HandleRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleRef>.NativeClassPtr);
			HandleRef.NativeFieldInfoPtr__wrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRef>.NativeClassPtr, "_wrapper");
			HandleRef.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandleRef>.NativeClassPtr, "_handle");
			HandleRef.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRef>.NativeClassPtr, 100671602);
			HandleRef.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleRef>.NativeClassPtr, 100671603);
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x0010F430 File Offset: 0x0010D630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1391263, RefRangeEnd = 1391266, XrefRangeStart = 1391262, XrefRangeEnd = 1391263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandleRef(Object wrapper, IntPtr handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleRef.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x0010F490 File Offset: 0x0010D690
		public unsafe IntPtr Handle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleRef.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x00014401 File Offset: 0x00012601
		public HandleRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0001440A File Offset: 0x0001260A
		public HandleRef()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleRef>.NativeClassPtr))
		{
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600376C RID: 14188 RVA: 0x0010F4D4 File Offset: 0x0010D6D4
		// (set) Token: 0x0600376D RID: 14189 RVA: 0x0001441C File Offset: 0x0001261C
		public unsafe Object _wrapper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleRef.NativeFieldInfoPtr__wrapper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleRef.NativeFieldInfoPtr__wrapper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x0600376E RID: 14190 RVA: 0x0010F504 File Offset: 0x0010D704
		// (set) Token: 0x0600376F RID: 14191 RVA: 0x0001443B File Offset: 0x0001263B
		public unsafe IntPtr _handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleRef.NativeFieldInfoPtr__handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandleRef.NativeFieldInfoPtr__handle)) = value;
			}
		}

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeFieldInfoPtr__wrapper;

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;
	}
}
