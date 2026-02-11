using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000248 RID: 584
	public class GainSpice : GainResources
	{
		// Token: 0x0600196B RID: 6507 RVA: 0x000BBBB0 File Offset: 0x000B9DB0
		// Note: this type is marked as 'beforefieldinit'.
		static GainSpice()
		{
			Il2CppClassPointerStore<GainSpice>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GainSpice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainSpice>.NativeClassPtr);
			GainSpice.NativeFieldInfoPtr_logTokenOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GainSpice>.NativeClassPtr, "logTokenOverride");
			GainSpice.NativeMethodInfoPtr_get_LogToken_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpice>.NativeClassPtr, 100667901);
			GainSpice.NativeMethodInfoPtr_WithLog_Public_GainSpice_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpice>.NativeClassPtr, 100667902);
			GainSpice.NativeMethodInfoPtr_WithLeader_Public_GainSpice_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpice>.NativeClassPtr, 100667903);
			GainSpice.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainSpice>.NativeClassPtr, 100667904);
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x000BBC44 File Offset: 0x000B9E44
		public unsafe override string LogToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136593, XrefRangeEnd = 136595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GainSpice.NativeMethodInfoPtr_get_LogToken_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000BBC88 File Offset: 0x000B9E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136596, RefRangeEnd = 136597, XrefRangeStart = 136595, XrefRangeEnd = 136596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainSpice WithLog(string logToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpice.NativeMethodInfoPtr_WithLog_Public_GainSpice_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GainSpice>(intPtr3) : null;
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x000BBCD8 File Offset: 0x000B9ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136597, RefRangeEnd = 136598, XrefRangeStart = 136597, XrefRangeEnd = 136597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainSpice WithLeader(bool withLeader = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withLeader;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpice.NativeMethodInfoPtr_WithLeader_Public_GainSpice_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GainSpice>(intPtr3) : null;
			}
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000BBD24 File Offset: 0x000B9F24
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 136604, RefRangeEnd = 136648, XrefRangeStart = 136598, XrefRangeEnd = 136604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GainSpice(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainSpice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GainSpice.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0000AF25 File Offset: 0x00009125
		public GainSpice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000BBD80 File Offset: 0x000B9F80
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0000AF2E File Offset: 0x0000912E
		public unsafe string logTokenOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpice.NativeFieldInfoPtr_logTokenOverride);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GainSpice.NativeFieldInfoPtr_logTokenOverride), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeFieldInfoPtr_logTokenOverride;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_get_LogToken_Protected_Virtual_get_String_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_WithLog_Public_GainSpice_String_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_WithLeader_Public_GainSpice_Boolean_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
