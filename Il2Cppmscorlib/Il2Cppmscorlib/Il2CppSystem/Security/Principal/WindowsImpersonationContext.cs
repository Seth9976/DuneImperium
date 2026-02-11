using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x02000288 RID: 648
	public class WindowsImpersonationContext : Object
	{
		// Token: 0x06002991 RID: 10641 RVA: 0x000DE4C0 File Offset: 0x000DC6C0
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsImpersonationContext()
		{
			Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "WindowsImpersonationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr);
			WindowsImpersonationContext.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, "_token");
			WindowsImpersonationContext.NativeFieldInfoPtr_undo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, "undo");
			WindowsImpersonationContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670091);
			WindowsImpersonationContext.NativeMethodInfoPtr_Undo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670092);
			WindowsImpersonationContext.NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670093);
			WindowsImpersonationContext.NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670094);
			WindowsImpersonationContext.NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670095);
			WindowsImpersonationContext.NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsImpersonationContext>.NativeClassPtr, 100670096);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000DE590 File Offset: 0x000DC790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375800, XrefRangeEnd = 1375806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000DE5C4 File Offset: 0x000DC7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375806, XrefRangeEnd = 1375822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_Undo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000DE5F8 File Offset: 0x000DC7F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1375823, RefRangeEnd = 1375824, XrefRangeStart = 1375822, XrefRangeEnd = 1375823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000DE638 File Offset: 0x000DC838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375824, XrefRangeEnd = 1375825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr DuplicateToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000DE678 File Offset: 0x000DC878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375825, XrefRangeEnd = 1375826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCurrentToken(IntPtr token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000DE6B8 File Offset: 0x000DC8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1375826, XrefRangeEnd = 1375827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RevertToSelf()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsImpersonationContext.NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		public WindowsImpersonationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x000DE6E8 File Offset: 0x000DC8E8
		// (set) Token: 0x0600299A RID: 10650 RVA: 0x0000DBC1 File Offset: 0x0000BDC1
		public unsafe IntPtr _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x000DE710 File Offset: 0x000DC910
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x0000DBDC File Offset: 0x0000BDDC
		public unsafe bool undo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr_undo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsImpersonationContext.NativeFieldInfoPtr_undo)) = value;
			}
		}

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeFieldInfoPtr_undo;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Void_0;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeMethodInfoPtr_CloseToken_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateToken_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentToken_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeMethodInfoPtr_RevertToSelf_Private_Static_Boolean_0;
	}
}
