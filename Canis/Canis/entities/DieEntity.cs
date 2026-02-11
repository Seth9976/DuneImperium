using System;
using Canis.actions;
using canis.archetypes;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000D2 RID: 210
	public class DieEntity<T> : Entity
	{
		// Token: 0x060009AB RID: 2475 RVA: 0x000424B4 File Offset: 0x000406B4
		// Note: this type is marked as 'beforefieldinit'.
		static DieEntity()
		{
			Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "DieEntity`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr);
			DieEntity<T>.NativeMethodInfoPtr_get_Faces_Public_Abstract_Virtual_New_get_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr, 100665335);
			DieEntity<T>.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr, 100665336);
			DieEntity<T>.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr, 100665337);
			DieEntity<T>.NativeMethodInfoPtr_get_CurrentIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr, 100665338);
			DieEntity<T>.NativeMethodInfoPtr_Roll_Public_Virtual_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr, 100665339);
			DieEntity<T>.NativeMethodInfoPtr_get_TopFace_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr, 100665340);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00042598 File Offset: 0x00040798
		public unsafe virtual IReadOnlyList<T> Faces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DieEntity<T>.NativeMethodInfoPtr_get_Faces_Public_Abstract_Virtual_New_get_IReadOnlyList_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000425E4 File Offset: 0x000407E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564511, XrefRangeEnd = 564524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DieEntity(Match m, PlayerEntity player = null, Archetype arch = null, string name = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arch);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieEntity<T>.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00042668 File Offset: 0x00040868
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 553228, RefRangeEnd = 553234, XrefRangeStart = 553228, XrefRangeEnd = 553234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DieEntity(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DieEntity<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieEntity<T>.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x000426D8 File Offset: 0x000408D8
		public unsafe int CurrentIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564524, XrefRangeEnd = 564535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieEntity<T>.NativeMethodInfoPtr_get_CurrentIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00042714 File Offset: 0x00040914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564535, XrefRangeEnd = 564554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action Roll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DieEntity<T>.NativeMethodInfoPtr_Roll_Public_Virtual_New_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00042760 File Offset: 0x00040960
		public unsafe T TopFace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564554, XrefRangeEnd = 564562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieEntity<T>.NativeMethodInfoPtr_get_TopFace_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000059D7 File Offset: 0x00003BD7
		public DieEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_get_Faces_Public_Abstract_Virtual_New_get_IReadOnlyList_1_T_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_String_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentIndex_Private_get_Int32_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_Roll_Public_Virtual_New_Action_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_get_TopFace_Public_get_T_0;
	}
}
