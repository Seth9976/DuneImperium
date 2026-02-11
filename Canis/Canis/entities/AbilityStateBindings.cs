using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000C4 RID: 196
	public class AbilityStateBindings<TBehavior> : Object
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x0003DF6C File Offset: 0x0003C16C
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityStateBindings()
		{
			Il2CppClassPointerStore<AbilityStateBindings<TBehavior>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityStateBindings`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBehavior>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateBindings<TBehavior>>.NativeClassPtr);
			AbilityStateBindings<TBehavior>.NativeFieldInfoPtr_StateBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateBindings<TBehavior>>.NativeClassPtr, "StateBindings");
			AbilityStateBindings<TBehavior>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_TBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindings<TBehavior>>.NativeClassPtr, 100665128);
			AbilityStateBindings<TBehavior>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindings<TBehavior>>.NativeClassPtr, 100665129);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0003E014 File Offset: 0x0003C214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561508, XrefRangeEnd = 561512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddBinding(int state, TBehavior behavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TBehavior).IsValueType)
			{
				TBehavior tbehavior = behavior;
				intPtr = ((tbehavior is string) ? IL2CPP.ManagedStringToIl2Cpp(tbehavior as string) : IL2CPP.Il2CppObjectBaseToPtr(tbehavior as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref behavior;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindings<TBehavior>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_TBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0003E09C File Offset: 0x0003C29C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 561521, RefRangeEnd = 561528, XrefRangeStart = 561512, XrefRangeEnd = 561521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityStateBindings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateBindings<TBehavior>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindings<TBehavior>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00005708 File Offset: 0x00003908
		public AbilityStateBindings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0003E0D8 File Offset: 0x0003C2D8
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00005711 File Offset: 0x00003911
		public unsafe Dictionary<int, TBehavior> StateBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateBindings<TBehavior>.NativeFieldInfoPtr_StateBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TBehavior>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateBindings<TBehavior>.NativeFieldInfoPtr_StateBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_StateBindings;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_TBehavior_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
