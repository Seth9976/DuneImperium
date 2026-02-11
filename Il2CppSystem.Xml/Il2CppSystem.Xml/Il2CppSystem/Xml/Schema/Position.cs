using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000115 RID: 277
	public sealed class Position : ValueType
	{
		// Token: 0x060018C1 RID: 6337 RVA: 0x0007F6F8 File Offset: 0x0007D8F8
		// Note: this type is marked as 'beforefieldinit'.
		static Position()
		{
			Il2CppClassPointerStore<Position>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Position");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Position>.NativeClassPtr);
			Position.NativeFieldInfoPtr_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Position>.NativeClassPtr, "symbol");
			Position.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Position>.NativeClassPtr, "particle");
			Position.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Position>.NativeClassPtr, 100667123);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0007F764 File Offset: 0x0007D964
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344943, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Position(int symbol, Object particle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Position>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Position.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0000A9CD File Offset: 0x00008BCD
		public Position(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0000A9D6 File Offset: 0x00008BD6
		public Position()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Position>.NativeClassPtr))
		{
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0007F7C4 File Offset: 0x0007D9C4
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0000A9E8 File Offset: 0x00008BE8
		public unsafe int symbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_symbol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_symbol)) = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0007F7EC File Offset: 0x0007D9EC
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0000AA03 File Offset: 0x00008C03
		public unsafe Object particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Position.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeFieldInfoPtr_symbol;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0;
	}
}
