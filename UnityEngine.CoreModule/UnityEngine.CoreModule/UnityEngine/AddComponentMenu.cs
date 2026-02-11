using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000126 RID: 294
	public sealed class AddComponentMenu : Attribute
	{
		// Token: 0x06001779 RID: 6009 RVA: 0x0006F994 File Offset: 0x0006DB94
		// Note: this type is marked as 'beforefieldinit'.
		static AddComponentMenu()
		{
			Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AddComponentMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr);
			AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_AddComponentMenu");
			AddComponentMenu.NativeFieldInfoPtr_m_Ordering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_Ordering");
			AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100666516);
			AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100666517);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0006FA14 File Offset: 0x0006DC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660723, XrefRangeEnd = 660725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddComponentMenu(string menuName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0006FA60 File Offset: 0x0006DC60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 660727, RefRangeEnd = 660732, XrefRangeStart = 660725, XrefRangeEnd = 660727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddComponentMenu(string menuName, int order)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00009413 File Offset: 0x00007613
		public AddComponentMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x0006FABC File Offset: 0x0006DCBC
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x0000941C File Offset: 0x0000761C
		public unsafe string m_AddComponentMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x0006FAE4 File Offset: 0x0006DCE4
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x0000943B File Offset: 0x0000763B
		public unsafe int m_Ordering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x0006FB0C File Offset: 0x0006DD0C
		public string componentMenu
		{
			get
			{
				return this.m_AddComponentMenu;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0006FB24 File Offset: 0x0006DD24
		public int componentOrder
		{
			get
			{
				return this.m_Ordering;
			}
		}

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeFieldInfoPtr_m_AddComponentMenu;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeFieldInfoPtr_m_Ordering;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
