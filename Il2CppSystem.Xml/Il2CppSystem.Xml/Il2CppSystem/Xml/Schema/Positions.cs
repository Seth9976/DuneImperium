using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000116 RID: 278
	public class Positions : Object
	{
		// Token: 0x060018C9 RID: 6345 RVA: 0x0007F81C File Offset: 0x0007DA1C
		// Note: this type is marked as 'beforefieldinit'.
		static Positions()
		{
			Il2CppClassPointerStore<Positions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Positions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Positions>.NativeClassPtr);
			Positions.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Positions>.NativeClassPtr, "positions");
			Positions.NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100667124);
			Positions.NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100667125);
			Positions.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100667126);
			Positions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Positions>.NativeClassPtr, 100667127);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0007F8B0 File Offset: 0x0007DAB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 392222, RefRangeEnd = 392226, XrefRangeStart = 392218, XrefRangeEnd = 392222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(int symbol, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000808 RID: 2056
		public unsafe Position this[int pos]
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 392229, RefRangeEnd = 392247, XrefRangeStart = 392226, XrefRangeEnd = 392229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref pos;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Position(intPtr);
				}
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x0007F950 File Offset: 0x0007DB50
		public unsafe int Count
		{
			[CallerCount(212)]
			[CachedScanResults(RefRangeStart = 390432, RefRangeEnd = 390644, XrefRangeStart = 390432, XrefRangeEnd = 390644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0007F98C File Offset: 0x0007DB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392247, XrefRangeEnd = 392253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Positions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Positions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Positions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0000AA22 File Offset: 0x00008C22
		public Positions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x0007F9C8 File Offset: 0x0007DBC8
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0000AA2B File Offset: 0x00008C2B
		public unsafe ArrayList positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Positions.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Positions.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_Int32_Object_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Position_Int32_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
