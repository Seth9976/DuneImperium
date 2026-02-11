using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000024 RID: 36
	public static class DeadZone : global::Il2CppSystem.Object
	{
		// Token: 0x06000266 RID: 614 RVA: 0x0001070C File Offset: 0x0000E90C
		// Note: this type is marked as 'beforefieldinit'.
		static DeadZone()
		{
			Il2CppClassPointerStore<DeadZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "DeadZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadZone>.NativeClassPtr);
			DeadZone.NativeMethodInfoPtr_SeparateNotNormalized_Public_Static_Vector2_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadZone>.NativeClassPtr, 100663630);
			DeadZone.NativeMethodInfoPtr_Separate_Public_Static_Vector2_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadZone>.NativeClassPtr, 100663631);
			DeadZone.NativeMethodInfoPtr_Circular_Public_Static_Vector2_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadZone>.NativeClassPtr, 100663632);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00010778 File Offset: 0x0000E978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769331, XrefRangeEnd = 769339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SeparateNotNormalized(float x, float y, float lowerDeadZone, float upperDeadZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerDeadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadZone.NativeMethodInfoPtr_SeparateNotNormalized_Public_Static_Vector2_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000107E0 File Offset: 0x0000E9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769339, XrefRangeEnd = 769355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Separate(float x, float y, float lowerDeadZone, float upperDeadZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerDeadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadZone.NativeMethodInfoPtr_Separate_Public_Static_Vector2_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00010848 File Offset: 0x0000EA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769364, RefRangeEnd = 769365, XrefRangeStart = 769355, XrefRangeEnd = 769364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Circular(float x, float y, float lowerDeadZone, float upperDeadZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerDeadZone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadZone.NativeMethodInfoPtr_Circular_Public_Static_Vector2_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002E0B File Offset: 0x0000100B
		public DeadZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_SeparateNotNormalized_Public_Static_Vector2_Single_Single_Single_Single_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_Separate_Public_Static_Vector2_Single_Single_Single_Single_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_Circular_Public_Static_Vector2_Single_Single_Single_Single_0;
	}
}
