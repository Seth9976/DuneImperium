using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000382 RID: 898
	public sealed class UnmanagedFunctionPointerAttribute : Attribute
	{
		// Token: 0x06003799 RID: 14233 RVA: 0x0010FF24 File Offset: 0x0010E124
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedFunctionPointerAttribute()
		{
			Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "UnmanagedFunctionPointerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr);
			UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "m_callingConvention");
			UnmanagedFunctionPointerAttribute.NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, 100671628);
			UnmanagedFunctionPointerAttribute.NativeMethodInfoPtr_get_CallingConvention_Public_get_CallingConvention_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, 100671629);
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x0010FF90 File Offset: 0x0010E190
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref callingConvention;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedFunctionPointerAttribute.NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600379B RID: 14235 RVA: 0x0010FFD8 File Offset: 0x0010E1D8
		public unsafe CallingConvention CallingConvention
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedFunctionPointerAttribute.NativeMethodInfoPtr_get_CallingConvention_Public_get_CallingConvention_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00014509 File Offset: 0x00012709
		public UnmanagedFunctionPointerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600379D RID: 14237 RVA: 0x00110014 File Offset: 0x0010E214
		// (set) Token: 0x0600379E RID: 14238 RVA: 0x00014512 File Offset: 0x00012712
		public unsafe CallingConvention m_callingConvention
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnmanagedFunctionPointerAttribute.NativeFieldInfoPtr_m_callingConvention)) = value;
			}
		}

		// Token: 0x04002D26 RID: 11558
		private static readonly IntPtr NativeFieldInfoPtr_m_callingConvention;

		// Token: 0x04002D27 RID: 11559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0;

		// Token: 0x04002D28 RID: 11560
		private static readonly IntPtr NativeMethodInfoPtr_get_CallingConvention_Public_get_CallingConvention_0;
	}
}
