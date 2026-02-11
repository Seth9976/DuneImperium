using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000122 RID: 290
	public class MonoTODOAttribute : Attribute
	{
		// Token: 0x0600137B RID: 4987 RVA: 0x0008473C File Offset: 0x0008293C
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTODOAttribute()
		{
			Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoTODOAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr);
			MonoTODOAttribute.NativeFieldInfoPtr_comment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr, "comment");
			MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr, 100666771);
			MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr, 100666772);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000847A8 File Offset: 0x000829A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTODOAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000847E4 File Offset: 0x000829E4
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTODOAttribute(string comment)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTODOAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(comment);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTODOAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0000632B File Offset: 0x0000452B
		public MonoTODOAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00084830 File Offset: 0x00082A30
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x00006334 File Offset: 0x00004534
		public unsafe string comment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTODOAttribute.NativeFieldInfoPtr_comment);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTODOAttribute.NativeFieldInfoPtr_comment), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeFieldInfoPtr_comment;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
