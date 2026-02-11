using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032F RID: 815
	public class ObjectHolderListEnumerator : Object
	{
		// Token: 0x060031F2 RID: 12786 RVA: 0x000FD208 File Offset: 0x000FB408
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolderListEnumerator()
		{
			Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolderListEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr);
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_isFixupEnumerator");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_list");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_startingVersion");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_currPos");
			ObjectHolderListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671136);
			ObjectHolderListEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671137);
			ObjectHolderListEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671138);
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000FD2C4 File Offset: 0x000FB4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385934, XrefRangeEnd = 1385936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFixupEnumerator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x000FD320 File Offset: 0x000FB520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385936, RefRangeEnd = 1385937, XrefRangeStart = 1385936, XrefRangeEnd = 1385936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000FD35C File Offset: 0x000FB55C
		public unsafe ObjectHolder Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x000113BA File Offset: 0x0000F5BA
		public ObjectHolderListEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060031F7 RID: 12791 RVA: 0x000FD39C File Offset: 0x000FB59C
		// (set) Token: 0x060031F8 RID: 12792 RVA: 0x000113C3 File Offset: 0x0000F5C3
		public unsafe bool m_isFixupEnumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator)) = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x000FD3C4 File Offset: 0x000FB5C4
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x000113DE File Offset: 0x0000F5DE
		public unsafe ObjectHolderList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x000FD3F4 File Offset: 0x000FB5F4
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x000113FD File Offset: 0x0000F5FD
		public unsafe int m_startingVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion)) = value;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x000FD41C File Offset: 0x000FB61C
		// (set) Token: 0x060031FE RID: 12798 RVA: 0x00011418 File Offset: 0x0000F618
		public unsafe int m_currPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos)) = value;
			}
		}

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeFieldInfoPtr_m_isFixupEnumerator;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeFieldInfoPtr_m_startingVersion;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeFieldInfoPtr_m_currPos;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0;
	}
}
