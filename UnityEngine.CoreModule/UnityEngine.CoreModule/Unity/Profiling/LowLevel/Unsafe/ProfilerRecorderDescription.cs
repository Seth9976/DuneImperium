using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x02000022 RID: 34
	[StructLayout(2)]
	public struct ProfilerRecorderDescription
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00019350 File Offset: 0x00017550
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorderDescription()
		{
			Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerRecorderDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr);
			ProfilerRecorderDescription.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "category");
			ProfilerRecorderDescription.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "flags");
			ProfilerRecorderDescription.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "dataType");
			ProfilerRecorderDescription.NativeFieldInfoPtr_unitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "unitType");
			ProfilerRecorderDescription.NativeFieldInfoPtr_reserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "reserved0");
			ProfilerRecorderDescription.NativeFieldInfoPtr_nameUtf8Len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "nameUtf8Len");
			ProfilerRecorderDescription.NativeFieldInfoPtr_nameUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "nameUtf8");
			ProfilerRecorderDescription.NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, 100663400);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00019420 File Offset: 0x00017620
		public unsafe MarkerFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderDescription.NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002824 File Offset: 0x00000A24
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, ref this));
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002836 File Offset: 0x00000A36
		public ProfilerCategory Category
		{
			get
			{
				return this.category;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000283E File Offset: 0x00000A3E
		public ProfilerMarkerDataType DataType
		{
			get
			{
				return this.dataType;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002846 File Offset: 0x00000A46
		public ProfilerMarkerDataUnit UnitType
		{
			get
			{
				return this.unitType;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000284E File Offset: 0x00000A4E
		public int NameUtf8Len
		{
			get
			{
				return this.nameUtf8Len;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002856 File Offset: 0x00000A56
		public unsafe byte* NameUtf8
		{
			get
			{
				return this.nameUtf8;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000285E File Offset: 0x00000A5E
		public string Name
		{
			get
			{
				return ProfilerUnsafeUtility.Utf8ToString(this.nameUtf8, this.nameUtf8Len);
			}
		}

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_unitType;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_reserved0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_nameUtf8Len;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_nameUtf8;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0;

		// Token: 0x040000E1 RID: 225
		[FieldOffset(0)]
		public readonly ProfilerCategory category;

		// Token: 0x040000E2 RID: 226
		[FieldOffset(2)]
		public readonly MarkerFlags flags;

		// Token: 0x040000E3 RID: 227
		[FieldOffset(4)]
		public readonly ProfilerMarkerDataType dataType;

		// Token: 0x040000E4 RID: 228
		[FieldOffset(5)]
		public readonly ProfilerMarkerDataUnit unitType;

		// Token: 0x040000E5 RID: 229
		[FieldOffset(8)]
		public readonly int reserved0;

		// Token: 0x040000E6 RID: 230
		[FieldOffset(12)]
		public readonly int nameUtf8Len;

		// Token: 0x040000E7 RID: 231
		[FieldOffset(16)]
		public readonly IntPtr nameUtf8;
	}
}
