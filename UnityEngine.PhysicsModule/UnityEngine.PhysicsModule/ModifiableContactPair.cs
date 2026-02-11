using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[StructLayout(2)]
	public struct ModifiableContactPair
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00007A1C File Offset: 0x00005C1C
		// Note: this type is marked as 'beforefieldinit'.
		static ModifiableContactPair()
		{
			Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ModifiableContactPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr);
			ModifiableContactPair.NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "actor");
			ModifiableContactPair.NativeFieldInfoPtr_otherActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "otherActor");
			ModifiableContactPair.NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "shape");
			ModifiableContactPair.NativeFieldInfoPtr_otherShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "otherShape");
			ModifiableContactPair.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "rotation");
			ModifiableContactPair.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "position");
			ModifiableContactPair.NativeFieldInfoPtr_otherRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "otherRotation");
			ModifiableContactPair.NativeFieldInfoPtr_otherPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "otherPosition");
			ModifiableContactPair.NativeFieldInfoPtr_numContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "numContacts");
			ModifiableContactPair.NativeFieldInfoPtr_contacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "contacts");
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002768 File Offset: 0x00000968
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, ref this));
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000277A File Offset: 0x0000097A
		public int colliderInstanceID
		{
			get
			{
				return Physics.ResolveShapeToInstanceID(this.shape);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002787 File Offset: 0x00000987
		public int otherColliderInstanceID
		{
			get
			{
				return Physics.ResolveShapeToInstanceID(this.otherShape);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00002794 File Offset: 0x00000994
		public int bodyInstanceID
		{
			get
			{
				return Physics.ResolveActorToInstanceID(this.actor);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000027A1 File Offset: 0x000009A1
		public int otherBodyInstanceID
		{
			get
			{
				return Physics.ResolveActorToInstanceID(this.otherActor);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000027AE File Offset: 0x000009AE
		public Vector3 bodyVelocity
		{
			get
			{
				return Physics.GetActorLinearVelocity(this.actor);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000156 RID: 342 RVA: 0x000027BB File Offset: 0x000009BB
		public Vector3 bodyAngularVelocity
		{
			get
			{
				return Physics.GetActorAngularVelocity(this.actor);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000027C8 File Offset: 0x000009C8
		public Vector3 otherBodyVelocity
		{
			get
			{
				return Physics.GetActorLinearVelocity(this.otherActor);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000027D5 File Offset: 0x000009D5
		public Vector3 otherBodyAngularVelocity
		{
			get
			{
				return Physics.GetActorAngularVelocity(this.otherActor);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000027E2 File Offset: 0x000009E2
		public int contactCount
		{
			get
			{
				return this.numContacts;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000027EA File Offset: 0x000009EA
		public Vector3 GetPoint(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000027F7 File Offset: 0x000009F7
		public void SetPoint(int i, Vector3 v)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002804 File Offset: 0x00000A04
		public Vector3 GetNormal(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002811 File Offset: 0x00000A11
		public void SetNormal(int i, Vector3 normal)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000281E File Offset: 0x00000A1E
		public float GetSeparation(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000282B File Offset: 0x00000A2B
		public void SetSeparation(int i, float separation)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002838 File Offset: 0x00000A38
		public Vector3 GetTargetVelocity(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002845 File Offset: 0x00000A45
		public void SetTargetVelocity(int i, Vector3 velocity)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002852 File Offset: 0x00000A52
		public float GetBounciness(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000285F File Offset: 0x00000A5F
		public void SetBounciness(int i, float bounciness)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000286C File Offset: 0x00000A6C
		public float GetStaticFriction(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002879 File Offset: 0x00000A79
		public void SetStaticFriction(int i, float staticFriction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002886 File Offset: 0x00000A86
		public float GetDynamicFriction(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002893 File Offset: 0x00000A93
		public void SetDynamicFriction(int i, float dynamicFriction)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000028A0 File Offset: 0x00000AA0
		public float GetMaxImpulse(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000028AD File Offset: 0x00000AAD
		public void SetMaxImpulse(int i, float value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000028BA File Offset: 0x00000ABA
		public void IgnoreContact(int i)
		{
			this.SetMaxImpulse(i, 0f);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000028CA File Offset: 0x00000ACA
		public uint GetFaceIndex(int i)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_actor;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_otherActor;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_shape;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_otherShape;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_otherRotation;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_otherPosition;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_numContacts;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_contacts;

		// Token: 0x040000A6 RID: 166
		[FieldOffset(0)]
		public IntPtr actor;

		// Token: 0x040000A7 RID: 167
		[FieldOffset(8)]
		public IntPtr otherActor;

		// Token: 0x040000A8 RID: 168
		[FieldOffset(16)]
		public IntPtr shape;

		// Token: 0x040000A9 RID: 169
		[FieldOffset(24)]
		public IntPtr otherShape;

		// Token: 0x040000AA RID: 170
		[FieldOffset(32)]
		public Quaternion rotation;

		// Token: 0x040000AB RID: 171
		[FieldOffset(48)]
		public Vector3 position;

		// Token: 0x040000AC RID: 172
		[FieldOffset(60)]
		public Quaternion otherRotation;

		// Token: 0x040000AD RID: 173
		[FieldOffset(76)]
		public Vector3 otherPosition;

		// Token: 0x040000AE RID: 174
		[FieldOffset(88)]
		public int numContacts;

		// Token: 0x040000AF RID: 175
		[FieldOffset(96)]
		public IntPtr contacts;
	}
}
