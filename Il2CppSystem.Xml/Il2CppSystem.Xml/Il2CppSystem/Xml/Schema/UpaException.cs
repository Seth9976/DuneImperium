using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000113 RID: 275
	public class UpaException : Exception
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x0007EEF0 File Offset: 0x0007D0F0
		// Note: this type is marked as 'beforefieldinit'.
		static UpaException()
		{
			Il2CppClassPointerStore<UpaException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "UpaException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpaException>.NativeClassPtr);
			UpaException.NativeFieldInfoPtr_particle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpaException>.NativeClassPtr, "particle1");
			UpaException.NativeFieldInfoPtr_particle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpaException>.NativeClassPtr, "particle2");
			UpaException.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpaException>.NativeClassPtr, 100667108);
			UpaException.NativeMethodInfoPtr_get_Particle1_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpaException>.NativeClassPtr, 100667109);
			UpaException.NativeMethodInfoPtr_get_Particle2_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpaException>.NativeClassPtr, 100667110);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0007EF84 File Offset: 0x0007D184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392063, XrefRangeEnd = 392069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpaException(Object particle1, Object particle2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpaException.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x0007EFE4 File Offset: 0x0007D1E4
		public unsafe Object Particle1
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpaException.NativeMethodInfoPtr_get_Particle1_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0007F024 File Offset: 0x0007D224
		public unsafe Object Particle2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpaException.NativeMethodInfoPtr_get_Particle2_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0000A8CB File Offset: 0x00008ACB
		public UpaException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0007F064 File Offset: 0x0007D264
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public unsafe Object particle1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0007F094 File Offset: 0x0007D294
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0000A8F3 File Offset: 0x00008AF3
		public unsafe Object particle2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeFieldInfoPtr_particle1;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeFieldInfoPtr_particle2;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle1_Public_get_Object_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle2_Public_get_Object_0;
	}
}
