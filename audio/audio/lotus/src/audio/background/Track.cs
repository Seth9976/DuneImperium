using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus.src.audio.background
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class Track : Object
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x000055A0 File Offset: 0x000037A0
		// Note: this type is marked as 'beforefieldinit'.
		static Track()
		{
			Il2CppClassPointerStore<Track>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "Track");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Track>.NativeClassPtr);
			Track.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track>.NativeClassPtr, "name");
			Track.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track>.NativeClassPtr, "sequence");
			Track.NativeFieldInfoPtr_activeSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Track>.NativeClassPtr, "activeSequence");
			Track.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100663404);
			Track.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100663405);
			Track.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100663406);
			Track.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100663407);
			Track.NativeMethodInfoPtr_get_Item_Public_get_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100663408);
			Track.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100663409);
			Track.NativeMethodInfoPtr_Play_Public_Void_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100663410);
			Track.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Track>.NativeClassPtr, 100663411);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000056AC File Offset: 0x000038AC
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000056E4 File Offset: 0x000038E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261894, XrefRangeEnd = 1261898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<string> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005724 File Offset: 0x00003924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00005764 File Offset: 0x00003964
		public unsafe int Count
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 428718, RefRangeEnd = 428731, XrefRangeStart = 428718, XrefRangeEnd = 428731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003D RID: 61
		public unsafe string this[int i]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1029194, RefRangeEnd = 1029200, XrefRangeStart = 1029194, XrefRangeEnd = 1029200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_get_Item_Public_get_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000057E4 File Offset: 0x000039E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1261905, RefRangeEnd = 1261909, XrefRangeStart = 1261898, XrefRangeEnd = 1261905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005818 File Offset: 0x00003A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261924, RefRangeEnd = 1261925, XrefRangeStart = 1261909, XrefRangeEnd = 1261924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(out string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr_Play_Public_Void_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				error = IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005864 File Offset: 0x00003A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261925, XrefRangeEnd = 1261933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Track()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Track>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Track.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000026E7 File Offset: 0x000008E7
		public Track(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000058A0 File Offset: 0x00003AA0
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000026F0 File Offset: 0x000008F0
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000058C8 File Offset: 0x00003AC8
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000270F File Offset: 0x0000090F
		public unsafe Il2CppStringArray sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000058F8 File Offset: 0x00003AF8
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000272E File Offset: 0x0000092E
		public unsafe PlayAudioSequence activeSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_activeSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayAudioSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Track.NativeFieldInfoPtr_activeSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_activeSequence;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_String_Int32_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_byref_String_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
