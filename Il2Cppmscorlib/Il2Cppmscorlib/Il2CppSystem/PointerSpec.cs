using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000171 RID: 369
	public class PointerSpec : Object
	{
		// Token: 0x060018DC RID: 6364 RVA: 0x0009AFD8 File Offset: 0x000991D8
		// Note: this type is marked as 'beforefieldinit'.
		static PointerSpec()
		{
			Il2CppClassPointerStore<PointerSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "PointerSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr);
			PointerSpec.NativeFieldInfoPtr_pointer_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, "pointer_level");
			PointerSpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667597);
			PointerSpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667598);
			PointerSpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667599);
			PointerSpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667600);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0009B06C File Offset: 0x0009926C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerSpec(int pointer_level)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointer_level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0009B0B4 File Offset: 0x000992B4
		[CallerCount(0)]
		public unsafe virtual Type Resolve(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0009B104 File Offset: 0x00099304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349623, XrefRangeEnd = 1349625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual StringBuilder Append(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0009B154 File Offset: 0x00099354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349625, XrefRangeEnd = 1349631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerSpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0000800E File Offset: 0x0000620E
		public PointerSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x0009B198 File Offset: 0x00099398
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00008017 File Offset: 0x00006217
		public unsafe int pointer_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerSpec.NativeFieldInfoPtr_pointer_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerSpec.NativeFieldInfoPtr_pointer_level)) = value;
			}
		}

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeFieldInfoPtr_pointer_level;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
