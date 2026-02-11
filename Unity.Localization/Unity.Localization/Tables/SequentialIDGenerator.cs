using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x02000027 RID: 39
	public class SequentialIDGenerator : Object
	{
		// Token: 0x0600022E RID: 558 RVA: 0x0001198C File Offset: 0x0000FB8C
		// Note: this type is marked as 'beforefieldinit'.
		static SequentialIDGenerator()
		{
			Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "SequentialIDGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr);
			SequentialIDGenerator.NativeFieldInfoPtr_m_NextAvailableId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr, "m_NextAvailableId");
			SequentialIDGenerator.NativeMethodInfoPtr_get_NextAvailableId_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr, 100663697);
			SequentialIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr, 100663698);
			SequentialIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr, 100663699);
			SequentialIDGenerator.NativeMethodInfoPtr_GetNextKey_Public_Virtual_Final_New_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr, 100663700);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00011A20 File Offset: 0x0000FC20
		public unsafe long NextAvailableId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialIDGenerator.NativeMethodInfoPtr_get_NextAvailableId_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00011A5C File Offset: 0x0000FC5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067278, RefRangeEnd = 1067280, XrefRangeStart = 1067270, XrefRangeEnd = 1067278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequentialIDGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00011A98 File Offset: 0x0000FC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067280, XrefRangeEnd = 1067281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequentialIDGenerator(long startingId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequentialIDGenerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00011AE0 File Offset: 0x0000FCE0
		[CallerCount(0)]
		public unsafe virtual long GetNextKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialIDGenerator.NativeMethodInfoPtr_GetNextKey_Public_Virtual_Final_New_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002D02 File Offset: 0x00000F02
		public SequentialIDGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00011B1C File Offset: 0x0000FD1C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002D0B File Offset: 0x00000F0B
		public unsafe long m_NextAvailableId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequentialIDGenerator.NativeFieldInfoPtr_m_NextAvailableId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequentialIDGenerator.NativeFieldInfoPtr_m_NextAvailableId)) = value;
			}
		}

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_m_NextAvailableId;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_get_NextAvailableId_Public_get_Int64_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_GetNextKey_Public_Virtual_Final_New_Int64_0;
	}
}
