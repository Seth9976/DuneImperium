using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.responseparsers
{
	// Token: 0x0200021A RID: 538
	public class StaticResponseParser<T> : ResponseParser<T>
	{
		// Token: 0x06001682 RID: 5762 RVA: 0x00073B68 File Offset: 0x00071D68
		// Note: this type is marked as 'beforefieldinit'.
		static StaticResponseParser()
		{
			Il2CppClassPointerStore<StaticResponseParser<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "StaticResponseParser`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticResponseParser<T>>.NativeClassPtr);
			StaticResponseParser<T>.NativeFieldInfoPtr__targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticResponseParser<T>>.NativeClassPtr, "_targets");
			StaticResponseParser<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticResponseParser<T>>.NativeClassPtr, 100668417);
			StaticResponseParser<T>.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_T_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticResponseParser<T>>.NativeClassPtr, 100668418);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00073C10 File Offset: 0x00071E10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 577094, RefRangeEnd = 577097, XrefRangeStart = 577094, XrefRangeEnd = 577097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticResponseParser(IEnumerable<T> targets)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticResponseParser<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticResponseParser<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00073C5C File Offset: 0x00071E5C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<T> ParseResponse(Match match, Object responseMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StaticResponseParser<T>.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_T_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0000ACBB File Offset: 0x00008EBB
		public StaticResponseParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00073CCC File Offset: 0x00071ECC
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		public unsafe IEnumerable<T> _targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticResponseParser<T>.NativeFieldInfoPtr__targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticResponseParser<T>.NativeFieldInfoPtr__targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeFieldInfoPtr__targets;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_T_Match_Object_0;
	}
}
