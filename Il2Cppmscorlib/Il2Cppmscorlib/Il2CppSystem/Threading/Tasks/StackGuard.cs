using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001D9 RID: 473
	public class StackGuard : Object
	{
		// Token: 0x06001F57 RID: 8023 RVA: 0x000B4D6C File Offset: 0x000B2F6C
		// Note: this type is marked as 'beforefieldinit'.
		static StackGuard()
		{
			Il2CppClassPointerStore<StackGuard>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "StackGuard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackGuard>.NativeClassPtr);
			StackGuard.NativeFieldInfoPtr_m_inliningDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "m_inliningDepth");
			StackGuard.NativeFieldInfoPtr_MAX_UNCHECKED_INLINING_DEPTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "MAX_UNCHECKED_INLINING_DEPTH");
			StackGuard.NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100668638);
			StackGuard.NativeMethodInfoPtr_EndInliningScope_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100668639);
			StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100668640);
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x000B4E00 File Offset: 0x000B3000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361118, RefRangeEnd = 1361119, XrefRangeStart = 1361117, XrefRangeEnd = 1361118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryBeginInliningScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000B4E3C File Offset: 0x000B303C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361119, RefRangeEnd = 1361121, XrefRangeStart = 1361119, XrefRangeEnd = 1361119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInliningScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_EndInliningScope_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x000B4E70 File Offset: 0x000B3070
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackGuard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackGuard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0000A287 File Offset: 0x00008487
		public StackGuard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x000B4EAC File Offset: 0x000B30AC
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x0000A290 File Offset: 0x00008490
		public unsafe int m_inliningDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackGuard.NativeFieldInfoPtr_m_inliningDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackGuard.NativeFieldInfoPtr_m_inliningDepth)) = value;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x000B4ED4 File Offset: 0x000B30D4
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0000A2AB File Offset: 0x000084AB
		public unsafe static int MAX_UNCHECKED_INLINING_DEPTH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StackGuard.NativeFieldInfoPtr_MAX_UNCHECKED_INLINING_DEPTH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackGuard.NativeFieldInfoPtr_MAX_UNCHECKED_INLINING_DEPTH, (void*)(&value));
			}
		}

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeFieldInfoPtr_m_inliningDepth;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeFieldInfoPtr_MAX_UNCHECKED_INLINING_DEPTH;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_EndInliningScope_Internal_Void_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
